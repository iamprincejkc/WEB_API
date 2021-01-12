using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_API_Token.Repository;

namespace Web_API_Token.Authorization
{
    public class MyAuthorizationServerProvider: OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            string ClientSecret;
            string ClientId;
            // The TryGetBasicCredentials method checks the Authorization header and
            // Return the ClientId and clientSecret
            if (!context.TryGetBasicCredentials(out ClientId, out ClientSecret))
            {
                context.SetError("invalid_client", "Client credentials could not be retrieved through the Authorization header.");
                context.Rejected();
                return;
            }
            //Check the existence of by calling the ValidateClient method
            sp_Validate_Client_Result client = new ClientMasterRepository().ValidateClient(ClientId, ClientSecret); //result type from stored procedure sp_Validate_Client_Result
            if (client != null)
            {
                // Client has been verified.
                context.OwinContext.Set("oauth:client", client); //result type from stored procedure sp_Validate_Client_Result
                context.Validated(ClientId);
                return;
            }
            else
            {
                // Client could not be validated.
                context.SetError("invalid_client", "Client credentials are invalid.");
                context.Rejected();
            }
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            using (UserMasterRepository _repo = new UserMasterRepository())
            {
                var user = _repo.ValidateUser(context.UserName, context.Password);
                if (user == null)
                {
                    context.SetError("invalid_grant", "Provided username and password is incorrect");
                    return;
                }
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                foreach (var item in user.UserRoles.Split(','))
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, item.Trim()));
                }
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                identity.AddClaim(new Claim("Email", user.UserEmailID));
                context.Validated(identity); 
            }
        }
    }
}
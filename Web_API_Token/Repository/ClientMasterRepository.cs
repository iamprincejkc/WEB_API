using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Token.Repository
{
    public class ClientMasterRepository:IDisposable
    {
        // SECURITY_DBEntities it is your context class
        SECURITY_DBEntities context = new SECURITY_DBEntities();

        //This method is used to check and validate the Client credentials
        public sp_Validate_Client_Result ValidateClient(string ClientID, string ClientSecret)
        {
            //return context.ClientMasters.FirstOrDefault(user =>
            // user.ClientId == ClientID
            //&& user.ClientSecret == ClientSecret);
            return context.sp_Validate_Client(ClientID,ClientSecret).FirstOrDefault();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
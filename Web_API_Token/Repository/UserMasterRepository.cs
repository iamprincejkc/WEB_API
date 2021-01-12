using System;
using System.Linq;
namespace Web_API_Token.Repository
{
    public class UserMasterRepository:IDisposable
    {
        // SECURITY_DBEntities it is your context class
        SECURITY_DBEntities context = new SECURITY_DBEntities();

        //This method is used to check and validate the user credentials
        public sp_Validate_User_Result ValidateUser(string username, string password)
        {
            //return context.UserMasters.FirstOrDefault(user =>
            //user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            //&& user.UserPassword == password);

            return context.sp_Validate_User(username, password).FirstOrDefault();

        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
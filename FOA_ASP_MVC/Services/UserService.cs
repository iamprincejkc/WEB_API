using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using FOA_ASP_MVC.Models;

namespace FOA_ASP_MVC.Services
{
    public class UserService
    {
        FirebaseClient client;
        public UserService()
        {
            client = new FirebaseClient("https://foodorderingapp-7b2d1-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> IsUserExist(string uname)
        {
            var user = (await client.Child("Users").OnceAsync<User>())
                .Where(e => e.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }
        public async Task<bool> RegisterUser(string uname, string pword)
        {
            if (await IsUserExist(uname) == false)
            {
                User user = new User()
                {
                    Username = uname,
                    Password = pword
                };
                await client.Child("Users").PostAsync(user);
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUser(string uname, string pword)
        {
            var user = (await client.Child("Users").OnceAsync<User>())
                .Where(e => e.Object.Username == uname)
                .Where(e => e.Object.Password == pword).FirstOrDefault();
            return (user != null);
        }
    }
}
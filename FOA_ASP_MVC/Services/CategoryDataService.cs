using System;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using FOA_ASP_MVC.Models;

namespace FOA_ASP_MVC.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;
        public CategoryDataService()
        {
            client = new FirebaseClient("https://foodorderingapp-7b2d1-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName,
                    CategoryPoster = c.Object.CategoryPoster,
                    ImageUrl = c.Object.ImageUrl

                }).ToList();

            return categories;
        }


        public async Task<List<Category>> UpdateCategoriesAsync(Category category)
        {
            return null;
        }
    }
}
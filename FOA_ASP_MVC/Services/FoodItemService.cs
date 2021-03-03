using Firebase.Database;
using FOA_ASP_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FOA_ASP_MVC.Services
{
    public class FoodItemService
    {
        FirebaseClient client;
        public FoodItemService()
        {
            client = new FirebaseClient("https://foodorderingapp-7b2d1-default-rtdb.firebaseio.com/");
        }
        public async Task<List<FoodItem>> GetFoodItemsAsync()
        {
            var fooditems = (await client.Child("FoodItems")
                .OnceAsync<FoodItem>())
                .Select(c => new FoodItem
                {
                    CategoryID = c.Object.CategoryID,
                    Description = c.Object.Description,
                    HomeSelected = c.Object.HomeSelected,
                    ImageUrl = c.Object.ImageUrl,
                    Name = c.Object.Name,
                    Price = c.Object.Price,
                    ProductID = c.Object.ProductID,
                    Rating = c.Object.Rating,
                    RatingDetail = c.Object.RatingDetail,

                }).ToList();

            return fooditems;
        }

        public async Task<List<FoodItem>> GetFoodItemsByCategoryAsync(int categoryid)
        {
            var fooditemsbyid = new List<FoodItem>();
            var items = (await GetFoodItemsAsync()).Where(c => c.CategoryID == categoryid).ToList();
            foreach (var item in items)
            {
                fooditemsbyid.Add(item);
            }
            return fooditemsbyid;
        }

        public async Task<List<FoodItem>> GetLatestFoodItemsAsync()
        {
            var fooditemsbyid = new List<FoodItem>();
            var items = (await GetFoodItemsAsync()).OrderByDescending(c => c.ProductID).ToList();
            foreach (var item in items)
            {
                fooditemsbyid.Add(item);
            }
            return fooditemsbyid;

        }

    }
}
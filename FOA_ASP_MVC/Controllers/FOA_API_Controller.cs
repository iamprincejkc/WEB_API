using FOA_ASP_MVC.Models;
using FOA_ASP_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FOA_ASP_MVC.Controllers
{
    [RoutePrefix("api/FOA")]
    public class FOA_API_Controller : ApiController
    {
        // Login

        [HttpPost]
        public async Task<IHttpActionResult> Login(string Username, string Password)
        {
            try
            {
                var userservice = new UserService();
                var Result = await userservice.LoginUser(Username, Password);
                if (Result)
                    return Ok();
                else
                {
                    return Ok(new { message = "Error : Wrong Username or Password" } );
                }
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        } 

        [HttpPost]
        public async Task<IHttpActionResult> Register(string Username, string Password)
        {
            try
            {
                var userservice = new UserService();
                var Result = await userservice.RegisterUser(Username, Password);
                if (Result)
                    return Ok();
                else
                {
                    return Ok(new {message = "Error : User Already Exist"} );
                }
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }



        // Food Items
        [HttpGet]
        [ActionName("FoodItems")]
        public async Task<IHttpActionResult> GetFoodItems()
        {
            List<FoodItem> FoodItemsByCategory = new List<FoodItem>();
            var data = await new FoodItemService().GetLatestFoodItemsAsync();
            foreach (var item in data)
            {
                FoodItemsByCategory.Add(item);
            }
            if (FoodItemsByCategory.Count > 0)
                return Ok(new { message = "Error : null" } );
            else
                return Ok(FoodItemsByCategory);
        }


        // Food Categories
        [HttpGet]
        [ActionName("Categories")]
        public async Task<IHttpActionResult> GetCategories()
        {
            try
            {
                List<Category> Categories = new List<Category>();
                var data = await new CategoryDataService().GetCategoriesAsync();
                foreach (var item in data)
                {
                    Categories.Add(item);
                }
                if (Categories.Count>0)
                    return Ok(Categories);
                else
                    return Ok(new { message = "Error : null" } );
            }
            catch (Exception)
            {
               return NotFound();
            }
        }

        [HttpPut]
        [ActionName("Categories")]
        public async Task<IHttpActionResult> UpdatetCategories(Category category)
        {
            try
            {
                List<Category> Categories = new List<Category>();
                var data = await new CategoryDataService().UpdateCategoriesAsync(category);
                if (Categories.Count > 0)
                    return Ok(Categories);
                else
                    return Ok(new { message = "Error : null" });
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}

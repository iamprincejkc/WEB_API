using FOA_ASP_MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FOA_ASP_MVC.Controllers
{
    public class FOAController : Controller
    {
        string baseUrl = "https://localhost:44388/";
        // GET: FOA
        public async Task<ActionResult> Index()
        {
            //List<Category> category = new List<Category>();
            string category;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage response = await client.GetAsync("api/FOA/Categories");
                if (response.IsSuccessStatusCode)
                {
                    category = await response.Content.ReadAsStringAsync();
                    if(category.Contains("Error"))
                    {
                        ModelState.AddModelError(string.Empty, "No data");
                    }
                    else
                    {
                        var result = JsonConvert.DeserializeObject<List<Category>>(category);
                        return View(result);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }

                return View();
            }
        }


        public async Task<ActionResult> FoodItems()
        {
            string food;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage response = await client.GetAsync("api/FOA/FoodItems/");
                if (response.IsSuccessStatusCode)
                {
                    food = await response.Content.ReadAsStringAsync();
                    if (food.Contains("Error"))
                    {
                        ModelState.AddModelError(string.Empty, "No data");
                    }
                    else
                    {
                        var result = JsonConvert.DeserializeObject<List<FoodItem>>(food);
                        return View(result);
                    }
                }
                else
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                return View();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEB_API_V2.Models;

namespace WEB_API_V2.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        string Baseurl = "https://localhost:44342";

        [HttpGet]
        [Route("Test")]
        public async Task<ActionResult> Index()
        {
            List<StoreModel> Store = new List<StoreModel>();
            List<StaffModel> Staff = new List<StaffModel>();
            List<ProductModel> Product = new List<ProductModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage response = await client.GetAsync("/api/MainAPI");

                if (response.IsSuccessStatusCode)
                {
                    //var TestResponse = response.Content.ReadAsStringAsync().Result;
                    //TestInfo = JsonConvert.DeserializeObject<List<TestClass>>(TestResponse);
                    Store = await response.Content.ReadAsAsync<List<StoreModel>>();
                    foreach(var i in Store)
                    {
                        foreach(var i2 in i.Product)
                        {
                            ProductModel prod = new ProductModel()
                            {
                                productid = i2.productid,
                                productname = i2.productname,
                                productquantity = Convert.ToInt32(i2.productquantity),
                                productprice = Convert.ToDecimal(i2.productprice),
                                storeid = i2.storeid,
                                staffid = i2.staffid
                            };
                            Product.Add(prod);
                        }
                        foreach(var i3 in i.Staff)
                        {
                            StaffModel st = new StaffModel()
                            {
                                staffid = i3.staffid,
                                storeid = i3.storeid,
                                staffname = i3.staffname,
                                staffaddress = i3.staffaddress
                            };
                            Staff.Add(st);
                        }
                    }

                    ViewBag.StaffList =  new SelectList(Staff.ToList(), "staffid", "staffname");
                    ViewBag.ProductList = new SelectList(Product.ToList(), "productid", "productname");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
                return View(Store);
            }
        }
    }
}
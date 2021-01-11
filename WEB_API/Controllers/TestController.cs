using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    public class TestController : Controller
    {
        string Baseurl = "https://localhost:44332/";
        public async Task<ActionResult> Index()
        {
            List<TestClass> TestInfo = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage Res = await client.GetAsync("api/TestAPI");

                if (Res.IsSuccessStatusCode)
                {
                    //var TestResponse = Res.Content.ReadAsStringAsync().Result;
                    //TestInfo = JsonConvert.DeserializeObject<List<TestClass>>(TestResponse);
                    TestInfo = await Res.Content.ReadAsAsync<List<TestClass>>();

                }
                return View(TestInfo);
            }
        }

        [HttpGet]
        [Route("Test/Details")]
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Test");
            }

            List<TestClass> test = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage result = await client.GetAsync("api/TestAPI/"+id);

                if (result.IsSuccessStatusCode)
                {

                    test = await result.Content.ReadAsAsync<List<TestClass>>();
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }

            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        [HttpPost]
        [Route("Test/Create")]
        public async Task<ActionResult> Create(TestClass testclass)
        {
            if (testclass == null)
            {
                return HttpNotFound();
            }

            if(ModelState.IsValid)
            {
                return View(testclass);
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44332/");

                HttpResponseMessage response = new HttpResponseMessage();
                response = await client.PostAsJsonAsync("api/TestAPI", testclass).ConfigureAwait(false);


                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;

                    ViewBag.isSuccess = result;

                    return RedirectToAction("Index", "Test");
                }
            }
            return View(testclass);
        }

        public ActionResult Create()
        {
            return View();
        }


        public async Task<ActionResult> Edit(int id)
        {

            List<TestClass> test = new List<TestClass>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage result = await client.GetAsync("api/TestAPI/" + id);

                if (result.IsSuccessStatusCode)
                {

                    test = await result.Content.ReadAsAsync<List<TestClass>>();
                }
            }
                return View(test);
        }

        [HttpPut]
        [Route("Test/Edit/{id}")]
        public async Task<ActionResult> Edit(TestClass testclass)
        {
            if (testclass == null)
            {
                return RedirectToAction("Index", "Test");
            }
            

            List<TestClass> test = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage result = await client.PutAsJsonAsync("api/TestAPI/" , testclass);

                if (result.IsSuccessStatusCode)
                {

                    test = await result.Content.ReadAsAsync<List<TestClass>>();

                    return RedirectToAction("Index", "Test");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }

            if (test == null)
            {
                return HttpNotFound();
            }
            return View();
        }


        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage result = await client.DeleteAsync("api/TestAPI/" + id);

                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            List<TestClass> test = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage result =client.GetAsync("api/TestAPI/" + id).Result;

                if (result.IsSuccessStatusCode)
                {

                    test =result.Content.ReadAsAsync<List<TestClass>>().Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }

            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }






    }
}
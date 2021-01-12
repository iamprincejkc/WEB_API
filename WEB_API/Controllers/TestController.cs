using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    public class TestController : Controller
    {
        string Baseurl = "https://localhost:44332/";

        [HttpGet]
        [Route("Test")]
        public async Task<ActionResult> Index()
        {
            List<TestClass> TestInfo = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage response = await client.GetAsync("api/TestAPI");

                if (response.IsSuccessStatusCode)
                {
                    //var TestResponse = response.Content.ReadAsStringAsync().Result;
                    //TestInfo = JsonConvert.DeserializeObject<List<TestClass>>(TestResponse);
                    TestInfo = await response.Content.ReadAsAsync<List<TestClass>>();
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
                return View(TestInfo);
            }
        }

        [HttpGet]
        [Route("Test/Details")]
        public async Task<ActionResult> Details(string id)
        {
            List<TestClass> test = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                HttpResponseMessage response = await client.GetAsync("api/TestAPI/" + id);

                if (response.IsSuccessStatusCode)
                {
                    sp_viewbyid_Result tresp = await response.Content.ReadAsAsync<sp_viewbyid_Result>();
                    TestClass testtemp = new TestClass()
                    { id = tresp.id, fname = tresp.fname, lname = tresp.lname, email = tresp.email };
                    test.Add(testtemp);
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

            if (ModelState.IsValid)
            {

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
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server error try after some time.");
                    }
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
            try
            {
                List<TestClass> test = new List<TestClass>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    HttpResponseMessage response = await client.GetAsync("api/TestAPI/" + id);

                    if (response.IsSuccessStatusCode)
                    {
                        sp_viewbyid_Result tresp = await response.Content.ReadAsAsync<sp_viewbyid_Result>();
                        TestClass testtemp = new TestClass()
                        { id = tresp.id, fname = tresp.fname, lname = tresp.lname, email = tresp.email };
                        test.Add(testtemp);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server error try after some time.");
                    }
                }
                return View(test);
            }
            catch (Exception)
            {
                return RedirectToAction("Test", "Index");
            }
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
                HttpResponseMessage response = await client.PutAsJsonAsync("api/TestAPI/", testclass);

                if (response.IsSuccessStatusCode)
                {
                    test = await response.Content.ReadAsAsync<List<TestClass>>();
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
                HttpResponseMessage response = await client.DeleteAsync("api/TestAPI/" + id);

                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
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
                HttpResponseMessage response = client.GetAsync("api/TestAPI/" + id).Result;

                if (response.IsSuccessStatusCode)
                {

                    test = response.Content.ReadAsAsync<List<TestClass>>().Result;
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
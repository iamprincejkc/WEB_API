using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApi_Dap.Models;
using WebApi_Dap.Repository;

namespace WebApi_Dap.Controllers
{
    public class TestController : Controller
    {
        string baseUrl= "https://localhost:44399/";
        // GET: Test
        public async Task<ActionResult> Index()
        {
            List<TestClass> TestInfo = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage response = await client.GetAsync("api/TestAPI");
                if (response.IsSuccessStatusCode)
                    TestInfo = await response.Content.ReadAsAsync<List<TestClass>>();
                else
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                return View(TestInfo);
            }
        }

        // GET: Test/Details/5
        public async Task<ActionResult> Details(int id)
        {
            TestClass test = new TestClass();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage response = await client.GetAsync("api/TestAPI/" + id);

                if (response.IsSuccessStatusCode)
                    test = await response.Content.ReadAsAsync<TestClass>();
                else
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }

            if (test == null)
                return HttpNotFound();
            return View(test);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        public async Task<ActionResult> Create(TestClass testclass)
        {
            if (testclass == null)
                return HttpNotFound();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
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
            return View(testclass);
        }

        // GET: Test/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                TestClass test = new TestClass();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    HttpResponseMessage response = await client.GetAsync("api/TestAPI/" + id);

                    if (response.IsSuccessStatusCode)
                         test = await response.Content.ReadAsAsync<TestClass>();
                    else
                         ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
                return View(test);
            }
            catch (Exception)
            {
                return RedirectToAction("Test", "Index");
            }
        }

        // POST: Test/Edit/5
        [HttpPut]
        public async Task<ActionResult> Edit(int id, TestClass testclass)
         {
            if (testclass == null)
                return RedirectToAction("Index", "Test");

            List<TestClass> test = new List<TestClass>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage response = await client.PutAsJsonAsync("api/TestAPI/",testclass);

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
                return HttpNotFound();

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> DeleteTest(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage response = await client.DeleteAsync("api/TestAPI/" + id);

                if (response.IsSuccessStatusCode)
                    return RedirectToAction("Index");
                else
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return RedirectToAction("Index");
        }
    }
}

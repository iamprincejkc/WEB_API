using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return RedirectToAction("Index", "Test");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TestClass testclass)
        {
            TestEntities db = new TestEntities();
                var obj = db.table1.Where(a => a.email.Equals(testclass.email) && a.lname.Equals(testclass.lname)).FirstOrDefault();
                if (obj != null)
                {
                    Session["email"] = obj.email.ToString();
                    Session["lname"] = obj.lname.ToString();
                    return RedirectToAction("UserDash");
                }
            return View(testclass);
        }

        public ActionResult UserDash()
        {
            if (Session["Email"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}
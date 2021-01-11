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
            if (Session["email"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult About()
        {
            if (Session["email"] != null)
            {
                return View();
               
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Contact()
        {
            Session.Remove("email");
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            if (Session["email"] != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
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
            if (Session["email"] != null)
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
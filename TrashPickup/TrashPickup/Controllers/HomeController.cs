using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Migrations;

namespace TrashPickup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("Customer"))
            {
                return RedirectToAction("Home", "Customer");
            }
            if (User.IsInRole("Employee"))
            {
                return RedirectToAction("WorkerHome", "Worker");
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
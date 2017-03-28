using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class WorkerController : Controller
    {
        // GET: Worker
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WorkerHome()
        {
            return View();
        }
        public ActionResult WorkerMap()
        {
            return View();
        }
    }
}

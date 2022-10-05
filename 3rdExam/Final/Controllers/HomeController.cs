using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        FinalEntities db = new FinalEntities();
        public ActionResult Index()
        {
            var req = db.Requests.OrderByDescending(r => r.ReqID).Take(10);
            ViewBag.request = req;
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
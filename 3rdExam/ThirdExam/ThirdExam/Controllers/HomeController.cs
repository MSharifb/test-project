using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdExam.Models;

namespace ThirdExam.Controllers
{
    public class HomeController : Controller
    {
        ThirdExamMorningEntities db = new ThirdExamMorningEntities();
        public ActionResult Index()
        {

            var featurs = db.Posts.OrderByDescending(p => p.ID).ToList().Take(2);
            var category = db.Categories.ToList();


            ViewBag.categories = category;
            ViewBag.feat_post = featurs;

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
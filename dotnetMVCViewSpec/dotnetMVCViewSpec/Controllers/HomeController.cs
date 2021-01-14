using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnetMVCViewSpec.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var temp =  Enumerable.Range(1, 5);
            return View(temp);
        }

        public ActionResult Money()
        {
            return PartialView("_ShowMoneyPartial",999);
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
using EFWithDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace EFWithDropDown.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.mytime = DateTime.Now.ToString();
            return RedirectToAction("GoHome", "Home");
        }
        public ActionResult GoHome()
        {
            ViewBag.mytime =DateTime.Now.ToString();
            ViewData["Mytime1"] = DateTime.Now.ToString();
            TempData["TempTime"] = DateTime.Now.ToString();
            return View("Index");
        }
    }
}
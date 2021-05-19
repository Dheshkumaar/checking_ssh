using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Sample")]
        public IActionResult SamplePost()
        {
            int firstnumber = Convert.ToInt32(Request.Form["firstnumber"]);
            int secondnumber = Convert.ToInt32(Request.Form["secondnumber"]);
            TempData["result"] = firstnumber + secondnumber;            
            return RedirectToAction("Result");
        }
        public IActionResult Result()
        {
            return View();
        }
    }
}

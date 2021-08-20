using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace Philters.Controllers
{
    [ActionPhilter]
    public class PhiltrController : Controller,IActionFilter
    {
        // GET: Philtr
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyIndex()
        {
            return View("Index");
        }

    }
    class ActionPhilter : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace.WriteLine(filterContext.ActionDescriptor+"Method executed successfully" + DateTime.Now.ToString());
            //After Action method executes
        }
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            var CtrlName = filterContext.RouteData.Values["Controller"];
            var actName = filterContext.RouteData.Values["action"];
            Trace.WriteLine(filterContext.RouteData +" Method is executing " + DateTime.Now.ToString()
                + " "+CtrlName.ToString()+ " From Method "+actName.ToString());
            //filterContext.Result = new RedirectResult("https://www.cricbuzz.com/");
            //Before Action method executes
        }
    }
}
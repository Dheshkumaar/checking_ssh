using System.Web.Mvc;

namespace MvcWithReact.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Render()
        {
            return View();
        }
    }
}
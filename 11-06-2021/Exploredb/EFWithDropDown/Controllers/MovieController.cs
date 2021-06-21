using EFWithDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWithDropDown.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            using (MoviesEntities mentity = new MoviesEntities())
            {
                var dataEF = new SelectList(mentity.Movies.ToList(), "sno", "MovieName");
                ViewData["MovEF"] = dataEF;
            }
            using (BookEntities bentity = new BookEntities())
            {
                var bookEF = new SelectList(bentity.tbl_book.ToList(), "BookId", "Title");
                ViewData["BookEF"] = bookEF;
            }
            return View();
        }
        public ActionResult Linq()
        {
            MoviesEntities mvc = new MoviesEntities();
            var query = (from i in mvc.Movies select i).ToList();
            return View(query);
        }
    }
}
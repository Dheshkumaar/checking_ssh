using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDLwithMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            #region ViewBag
            List<SelectListItem> mlist = new List<SelectListItem>()
            {
                new SelectListItem{ Text ="Roman Holiday" ,Value="1"},
                new SelectListItem{ Text ="Pretty Woman" ,Value="2"},
                new SelectListItem{ Text ="Great Escape" ,Value="3"},
                new SelectListItem{ Text ="Boy with stripped Pyjama" ,Value="4"},
                new SelectListItem{ Text ="Memories" ,Value="5"},
                new SelectListItem{ Text ="12 Age" ,Value="6"},
                new SelectListItem{ Text ="Love story 1972" ,Value="7"},
                new SelectListItem{ Text ="BeautifulMind", Value="8"}
            };
            ViewBag.MovList = mlist;
            #endregion
            #region ViewData
            List<SelectListItem> mvdlist = new List<SelectListItem>()
            {
                new SelectListItem{ Text="Fault in our stars",Value="0"},
                new SelectListItem{ Text ="Roman Holiday" ,Value="1"},
                new SelectListItem{ Text ="Pretty Woman" ,Value="2"},
                new SelectListItem{ Text ="Great Escape" ,Value="3"},
                new SelectListItem{ Text ="Boy with stripped Pyjama" ,Value="4"},
                new SelectListItem{ Text ="Memories" ,Value="5"},
                new SelectListItem{ Text ="12 Age" ,Value="6"},
                new SelectListItem{ Text ="Love story 1972" ,Value="7"},
                new SelectListItem{ Text ="BeautifulMind", Value="8"}
            };
            ViewData["MoveList"] = mvdlist;
            #endregion
            #region TempData
            List<SelectListItem> mtdlist = new List<SelectListItem>()
            {
                new SelectListItem{ Text="Fault in our stars",Value="0"},
                new SelectListItem{ Text ="Roman Holiday" ,Value="1"},
                new SelectListItem{ Text ="Pretty Woman" ,Value="2"},
                new SelectListItem{ Text ="Great Escape" ,Value="3"},
                new SelectListItem{ Text ="Boy with stripped Pyjama" ,Value="4"},
                new SelectListItem{ Text ="Memories" ,Value="5"},
                new SelectListItem{ Text ="12 Age" ,Value="6"},
                new SelectListItem{ Text ="Love story 1972" ,Value="7"},
                new SelectListItem{ Text ="BeautifulMind", Value="8"}
            };
            TempData["movieList"] = mtdlist;
            #endregion
            var moList = new List<conMList>();
            foreach (MoviesList ml in Enum.GetValues(typeof(MoviesList)))
                moList.Add(new conMList
                {
                    value = (int) ml,
                    Text = ml.ToString()
                });
            ViewBag.EnuMovList = moList;
            return View();
        }
        public enum MoviesList
        {
            Orphan,
            Night_at_the_Museum,
            Cuckkos_Nest,
            Memento,
            SoundOfMusic,
            True_story,
            The_juror,
            GoneGirl,
            Why_him
        }
        public struct conMList
        {
            public int value { get; set; }
            public string Text { get; set; }
        }
    }
}
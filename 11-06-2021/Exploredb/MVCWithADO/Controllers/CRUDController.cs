using MVCWithADO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithADO.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult Index()
        {
            CRUDModel mdl = new CRUDModel();
            DataTable dt = mdl.DisplayBooks();
            return View("Home",dt);
        }

        public ActionResult Insert()
        {
            return View("Create");
        }

        public ActionResult InsertRecord(FormCollection form,string action)
        {
            if(action == "submit")
            {
                CRUDModel mdl = new CRUDModel();
                string Title = form["txtTitle"];
                int aid = Convert.ToInt32(form["txtAid"]);
                double price = Convert.ToDouble(form["txtPrice"]);
                int rowIns = mdl.NewBook(Title, aid, price);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Author()
        {
            CRUDModel mdl = new CRUDModel();
            DataTable dt = mdl.DisplayAuthors();
            return View("DisplayAuthors",dt);
        }
        public ActionResult Insert_Authors()
        {
            return View("Create_Authors");
        }
        public ActionResult InsertAuthorsRecord(FormCollection form, string action)
        {
            if (action == "submit")
            {
                CRUDModel mdl = new CRUDModel();
                string AuthorName = form["txtAuthorName"];
                int rowIns = mdl.NewAuthor(AuthorName);
                return RedirectToAction("Author");
            }
            else
            {
                return RedirectToAction("Author");
            }
        }
    }
}
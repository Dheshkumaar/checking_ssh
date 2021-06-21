using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCusgDPR.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace MVCusgDPR.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<BookModel> BKlist = new List<BookModel>();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString)) 
            {
                BKlist = dbcon.Query<BookModel>("Select * from tbl_book").ToList();    
            }
            return View(BKlist);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            BookModel bk = new BookModel();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                bk = dbcon.Query<BookModel>("Select * from tbl_book where bookId=" + id,new {id}).SingleOrDefault();
            }
            return View(bk);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(BookModel bmodel)
        {
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                string query = "Insert into tbl_book(Title,AuthorId,Price) Values('" + bmodel.Title + "'," + bmodel.AuthorId + "," + bmodel.price + ")";
                int rowins = dbcon.Execute(query);
            }
            return RedirectToAction("Index");
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            BookModel bk = new BookModel();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                bk = dbcon.Query<BookModel>("Select * from tbl_book where bookId=" + id, new { id }).SingleOrDefault();
            }
            return View(bk);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,BookModel bkm)
        {
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                string query = "Update tbl_book set title='"+bkm.Title+"',AuthorId="+bkm.AuthorId+",price="+bkm.price+" where bookId="+id;
                int editrow = dbcon.Execute(query);
            }
            return RedirectToAction("Index");
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                string query = "Delete from tbl_book where BookId=" + id;
                int delrow = dbcon.Execute(query);
            }
            return RedirectToAction("Index");
        }
    }
}

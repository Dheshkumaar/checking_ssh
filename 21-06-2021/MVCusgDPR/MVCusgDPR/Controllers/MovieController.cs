using Dapper;
using MVCusgDPR.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCusgDPR.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            List<MovieModel> Movieslist = new List<MovieModel>();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                Movieslist = dbcon.Query<MovieModel>("Select * from Movies").ToList();
            }
            return View(Movieslist);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            MovieModel movie = new MovieModel();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                movie = dbcon.Query<MovieModel>("Select * from Movies where sno=" + id, new { id }).SingleOrDefault();
            }
            return View(movie);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(MovieModel movie)
        {
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                string query = "Insert into Movies(MovieName) Values('"+ movie.MovieName+"')";
                int rowins = dbcon.Execute(query);
            }
            return RedirectToAction("Index");
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            MovieModel movie = new MovieModel();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                movie = dbcon.Query<MovieModel>("Select * from Movies where sno=" + id, new { id }).SingleOrDefault();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,MovieModel movie)
        {
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                string query = "Update Movies set MovieName='" + movie.MovieName + "' where sno=" + id;
                int editrow = dbcon.Execute(query);
            }
            return RedirectToAction("Index");
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                string query = "Delete from Movies where sno=" + id;
                int delrow = dbcon.Execute(query);
            }
            return RedirectToAction("Index");
        }
    }
}

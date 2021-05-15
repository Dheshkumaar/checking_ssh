using Microsoft.AspNetCore.Mvc;
using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication.Controllers
{
    public class CommentController : Controller
    {
        static List<Comment> comments = new List<Comment>()
            {
                new Comment() { Id= 1,CommenText="First comment",PostId=101},
                new Comment() { Id = 2, CommenText="Second comment",PostId=102 },
                new Comment() { Id = 3, CommenText="Third comment",PostId=103}
            };
        public IActionResult Index()
        {
            return View(comments);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            comments.Add(comment);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            int idx = comments.FindIndex(p => p.Id == id);
            return View(comments[idx]);
        }
        [HttpPost]
        public IActionResult Edit(int id, Comment comment)
        {
            int idx = comments.FindIndex(p => p.Id == id);
            comments[idx].CommenText = comment.CommenText;
            return RedirectToAction("Index");
        }
    }
}

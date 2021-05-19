using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcRegister.Models;
using MvcRegister.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRegister.Controllers
{
    public class UserController : Controller
    {
        private IUser<UserModel> _repo;
        public UserController(IUser<UserModel> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserModel user)
        {
            try
            {
                _repo.Register(user);
                TempData["un"] = user.Username;
                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            if (TempData.Count == 0)
                return View();
            UserModel user = new UserModel();
            user.Username = TempData.Peek("un").ToString();
            return View(user);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel user)
        {
            try
            {
                if (_repo.Login(user))
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}

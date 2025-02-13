using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.web.Controllers
{

    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "admin")
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("Username", "Invalid username.");
                ModelState.AddModelError("Password", "Invalid password.");
            }

            return View(model);
        }
    }

    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
    }
}
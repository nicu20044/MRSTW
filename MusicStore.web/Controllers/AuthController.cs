using System.Web.Mvc;
using BusinessLogic.Interfaces;

namespace MusicStore.web.Controllers
{
    public class AuthController : Controller
    {
        private readonly ISession _sessionService;

        public AuthController(ISession sessionService)
        {
            _sessionService = sessionService;
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (email == "test@mail.com" && password == "password")
            {
                var token = _sessionService.GenerateSessionToken(1);
                return Json(new { Token = token });
            }

            return new HttpStatusCodeResult(401, "Unauthorized");
        }

        public ActionResult Register()
        {
            return View("Register");
        }
    }
}





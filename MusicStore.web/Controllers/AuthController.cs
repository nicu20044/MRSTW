using System.Web.Mvc;

namespace MusicStore.web.Controllers
{
    public class AuthController : Controller
    {

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Register()
        {
            return View("Register");
        }
    }
}


using System.Threading.Tasks;
using System.Web.Mvc;
using BusinessLogic.Services;
using Domain.Entities.User;
using BusinessLogic.Core.AdminUser;

namespace MusicStore.web.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public async Task<JsonResult> LoginAction(ULoginData model)
        {
            if (!ModelState.IsValid)
                return Json(new { success = false, message = "Date invalide." });

            // Apelăm serviciul pentru a autentifica utilizatorul
            var response = await _authService.UserLoginActionAsync(model);

            if (!response.Status)
                return Json(new { success = false, message = response.StatusMsg });

            // Setează tokenul și rolul în sesiune
            Session["UserToken"] = response.Token;
            Session["UserRole"] = response.UserRole;

            // Logica de redirecționare în funcție de rol
            if (response.UserRole == "Admin")
            {
                return Json(new { success = true, role = response.UserRole, redirectUrl = "/Admin" });
            }
            else if (response.UserRole == "Artist")
            {
                return Json(new { success = true, role = response.UserRole, redirectUrl = "/Index" });
            }
            else if (response.UserRole == "Listener")
            {
                return Json(new { success = true, role = response.UserRole, redirectUrl = "/Index" });
            }
            else
            {
                return Json(new { success = false, message = "Rol necunoscut." });
            }
        }

        public ActionResult Logout()
        {
            // Ștergem sesiunea utilizatorului
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}

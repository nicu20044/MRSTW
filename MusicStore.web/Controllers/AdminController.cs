using System.Web.Mvc;

namespace MusicStore.web.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}
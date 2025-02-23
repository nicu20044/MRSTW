using System.Web.Mvc;

namespace MusicStore.web.Controllers
{
    public class LibraryController : Controller
    {
        // GET
        public ActionResult Library()
        {
            return View();
        }
    }
}
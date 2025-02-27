using System.Web.Mvc;

namespace MusicStore.web.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public ActionResult ProductPage()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.web.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult ManageContent()
        {
            return View();
        }

        public ActionResult ManageUsers()
        {
            return View();
        }
    }
}
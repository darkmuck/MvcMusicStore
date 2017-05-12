using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.title = "this is the title.";
            return View();
        }

        public ActionResult Browse(string genre)
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
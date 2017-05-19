using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {

        public ActionResult Index()
        {
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
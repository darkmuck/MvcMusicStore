using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewModels.ShoppingCartViewModel cart = new ViewModels.ShoppingCartViewModel();
            cart.Albums = new List<string>();
            cart.Albums.Add("Album 1");
            cart.Albums.Add("Album 2");
            cart.Total = 10;

            return View(cart);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
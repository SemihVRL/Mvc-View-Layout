using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Temel_View_Layout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "merhaba";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About controller mesajıdır bu.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact controller mesajıdır bu";

            return View();
        }

        public ActionResult Profilim()
        {
            ViewBag.Message = "Merhaba ben semih vural";
            return View();
        }

        public ActionResult Yorum()
        {
            return View();
        }
    }
}
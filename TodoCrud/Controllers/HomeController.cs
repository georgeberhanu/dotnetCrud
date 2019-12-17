using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoCrud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "" +
                "Name:Tesfaye Berhanu " +
                "Id:ATR/4668/09 " +
                "section: 3.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = ".";

            return View();
        }
    }
}
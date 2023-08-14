using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["UserName"] != null)
            {
                ViewBag.UserName = Session["UserName"];
                return View();
            }
            return RedirectToAction("DangNhap", "DN");
        }
    }
}
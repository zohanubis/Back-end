using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //Render Body () -> 1 lần
        //Render Section ("name" -> Gọi nhiều lần
        //Render Page ("page.cshmtl) -> gọi nhiều lần -> Chia nhỏ giao diện thành nhiều phần con
        //=> Chạy 1 View Action/Controller
    }
}
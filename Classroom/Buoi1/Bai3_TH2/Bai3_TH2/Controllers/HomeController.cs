using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai3_TH2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult EmpDetail()
        {
            ViewBag.EmpId = 101;
            ViewBag.Name = "Huy";
            ViewBag.Salary = 1000;
            ViewBag.Gender = "M";
            ViewBag.Address = "4 Dương Văn Dương";
            //Razor For
            ViewBag.Year = 2019;
            ViewBag.Positions = new List<string>() { "Intern", "Manager", "Senior" };
            return View();
        }
    }
}
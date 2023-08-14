using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ex3.Models;

namespace Ex3.Controllers
{
    public class DNController : Controller
    {
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        // GET: DN
        [HttpPost]
        public ActionResult DangNhap(string name, string password)
        {
            if("yennh".Equals(name) && "123456".Equals(password))
            {
                Session["user"] = new User() { Login = name, UserName = "Phạm Hồ Đăng Huy" };
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult DangKy(string name, string password, string rt_password)
        {
            if (name.Length >= 5 && password.Length >= 6 && rt_password.Equals(password))
            {
                // Handle registration logic here
                return RedirectToAction("DangNhap","DN");
            }
            else { return View(); }
            
        }
        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
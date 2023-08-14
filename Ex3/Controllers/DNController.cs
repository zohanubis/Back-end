using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ex3.Models.User;

namespace Ex3.Controllers
{
    public class DNController : Controller
    {
        // GET: DN
        [HttpPost]
        public ActionResult DangNhap(string name, string password)
        {
            if("yennh".Equals(name) && "123456".Equals(password))
            {
                Session["user"] = new User() { login = name, Us}
            }
        }

        [HttpPost]
        public ActionResult DangKy(User user)
        {
            if (user.UserName.Length >= 5 && user.PassWord.Length >= 6 && user.PassWord == user.ReTypePassWord)
            {
                // Handle registration logic here
                return RedirectToAction("DangNhap");
            }
            return View("DangKy");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Exercise3.Models;

namespace Exercise3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(string txt_FullName, string txt_Id, string txt_Email, string File_image, string t_Note, bool Chk1, bool Chk2, bool Chk3, string opRadios, string sc)
        {
            Session["info"] = new Information()
            {
                FullName = txt_FullName,
                IDStudent = txt_Id,
                FileImage = File_image,
                Email = txt_Email,
                Note = t_Note,
                Check1 = Chk1,
                Check2 = Chk2,
                Check3 = Chk3,
                ChooseWorkTime = opRadios,
                SelectCourse = sc

            };
            return RedirectToAction("MHXacNhan", "Home");
        }

        public ActionResult Index_DataAnnoutation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index_DataAnnoutation(Information inf)
        {
            if (ModelState.IsValid)
            {
                Session["info"] = new Information()
                {
                    FullName = inf.FullName,
                    IDStudent = inf.IDStudent,
                    FileImage = inf.FileImage,
                    Email = inf.Email,
                    Note = inf.Note,
                    Check1 = inf.Check1,
                    Check2 = inf.Check2,
                    Check3 = inf.Check3,
                    ChooseWorkTime = inf.ChooseWorkTime,
                    SelectCourse = inf.SelectCourse

                };
                return RedirectToAction("MHXacNhan", "Home");
            }
            else return View();
        }
        public ActionResult MHList()
        {
            List<string> list = new List<string>();
            list.Add("Truong Manh Hung");
            list.Add("Nguyen Hai Yen");
            list.Add("Truong Thi Khanh Uyen");
            list.Add("Truong Nguyen Quynh Anh");
            ViewBag.DuLieu = list;
            return View();
        }
        public ActionResult MHViewBagList2()
        {
            ViewBag.Countries = new List<string>()
            {
                "Viet Nam", "Thai Lan","Sigapore", "Indonesia", "Japan"
            };
            return View();
        }
        [HttpPost]
       
        public ActionResult MHXacNhan()
        {
            return View();
        }
    }
}
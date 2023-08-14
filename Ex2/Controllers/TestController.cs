using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Models.KhoaModels khoaCNTT = new Models.KhoaModels();
            khoaCNTT.Message = " FIT-HUIT : HỌC TẬP - NĂNG ĐỘNG - SÁNG TẠO";
                return View(khoaCNTT);
        }
    }
}
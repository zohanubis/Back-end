﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        } 
        public string Index(int id, string name)
        {
            return "ID : " + id + " Name : " + name;
        }   
        public string Index1()
        {
            return "ID : " + Request.QueryString["id"] + " Name = " + Request.QueryString["name"] + " Old = " + Request.QueryString["old"]; //Lay tham so tu URL
        }
    }
}
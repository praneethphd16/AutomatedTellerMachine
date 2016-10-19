﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Having Trouble ? Send us a message";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message) {
            ViewBag.TheMessage = "Thanks we got your details";
            return View();
        }

        public ActionResult Foo() {


            return View("Contact");
        }
         
        public ActionResult Serial(string letterCase) {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower") {

                return Content(serial.ToLower());
            }

            return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
        }
    }
}
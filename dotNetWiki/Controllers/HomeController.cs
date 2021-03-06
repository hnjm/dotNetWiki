﻿using dotNetWiki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetWiki.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new WikiContext();
            var pages = context.Pages.OrderByDescending(o => o.Id).ToList();
            return View(pages);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
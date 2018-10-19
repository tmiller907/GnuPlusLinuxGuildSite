﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GnuPlusLinux.Models;

namespace GnuPlusLinux.Controllers
{
    public class HomeController : Controller
    {
		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		[HttpGet]
        public IActionResult Login()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		[HttpGet]
        public IActionResult Application()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		[HttpGet]
        public IActionResult Members()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        public IActionResult Information()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		[HttpGet]
        public IActionResult Calendar()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		[HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

		[HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GnuPlusLinux.Controllers
{
    public class ForumsController : Controller
    {
        private const string TITLE = "Forums";
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to the GNU Plus Linux Fourms";
            ViewBag.Title = TITLE;

            return View();
        }

    }
}
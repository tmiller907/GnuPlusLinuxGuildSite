using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GnuPlusLinuxDAL;
using Microsoft.AspNetCore.Mvc;

namespace GnuPlusLinux.Controllers
{
    public class MemberController : Controller
    {
        public const string TITLE = "Member";
        private AccountContext _context;
        public MemberController(AccountContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(int? id)
        {
            ViewBag.Title = TITLE;
            Account account = new Account();
            if ((id ?? 0) > 0)
            {
                account = _context.Accounts.Where(a => a.AccountId == id).FirstOrDefault();
            }
            return View(account);
        }

        [HttpPost]
        public IActionResult Register(Account userAccount)
        {
            ViewBag.Title = TITLE;
            if (ModelState.IsValid)
            {
                var savedAccount = _context.Accounts.Where(a => a.AccountId == userAccount.AccountId).FirstOrDefault();
                if (savedAccount == null)
                {
                    _context.Accounts.Add(userAccount);
                } else
                {
                    savedAccount = userAccount;
                }
                _context.SaveChanges();
                return RedirectToAction("Register", new { id = userAccount.AccountId });
            }
            return View();
        }
    }
}
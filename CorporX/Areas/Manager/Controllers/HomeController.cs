﻿using CorporX.Data;
using Microsoft.AspNetCore.Mvc;
using CorporX.Filters;
using CorporX.Data.Models.Entities;

namespace CorporX.Areas.Manager.Controllers
{
    [TypeFilter(typeof(Profile))]
    [Area("Manager")]
    public class HomeController : Controller
    {
        private readonly CorporxDbContext _context;
        private User user => RouteData.Values["User"] as User;
        public HomeController(CorporxDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
         
            if (user==null)
            {
                return RedirectToAction("login", "account", new { area = "manager" });
            }
            var profile = _context.Users.Find(user.Id);

            return View(profile);
        }
    }
}

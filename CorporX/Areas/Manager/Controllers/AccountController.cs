using System;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Areas.Manager.ViewModels;
using CorporX.Data;
using CorporX.Data.Models.Entities;
using CorporX.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoHelper;

namespace CorporX.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class AccountController : Controller
    {
        private readonly CorporxDbContext _context;
        public AccountController(CorporxDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

                if (user != null)
                {
                    if (Crypto.VerifyHashedPassword(user.Password, model.Password))
                    {
                        user.Token = Crypto.HashPassword(DateTime.Now.ToString());
                        //user.Token = Guid.NewGuid().ToString();

                        _context.SaveChanges();

                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = DateTime.Now.AddYears(1),
                            HttpOnly = true
                        });
                            return RedirectToAction("index", "Home", new { area = "manager" });
                      
                    }
                }

                ModelState.AddModelError("Password", "Email or password is incorrect");
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (_context.Users.Any(u => u.Email == model.Email))
            {
                ModelState.AddModelError("Email", "This e-mail address is already registered");
            }

            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Name = model.Name,
                    Lastname = model.Lastname,
                    Email = model.Email,
                    Password = Crypto.HashPassword(model.Password),
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("login", "account", new { area = "manager" });
            }
            return View(model);
        }
    }
}

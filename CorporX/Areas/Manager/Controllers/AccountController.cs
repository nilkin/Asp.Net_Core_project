using System;
using System.Threading.Tasks;
using CorporX.Areas.Manager.ViewModels;
using CorporX.Data;
using CorporX.Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                    //if (Crypto.VerifyHashedPassword(user.Password, model.Password))
                    //{
                        //user.Token = Crypto.HashPassword(DateTime.Now.ToString());
                        user.Token = Guid.NewGuid().ToString();

                        _context.SaveChanges();

                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = DateTime.Now.AddDays(1),
                            HttpOnly = true
                        });

                        return RedirectToAction("index","Home",new { area = "manager"});
                    //}
                }

                ModelState.AddModelError("Password", "E-poçt və ya şifrə yanlışdır");
            }

            return View(model);
        }

    }
}

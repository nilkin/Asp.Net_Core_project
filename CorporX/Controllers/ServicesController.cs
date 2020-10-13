using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.Models;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CorporX.Controllers
{
    public class ServicesController : Controller
    {
        private readonly CorporxDbContext _context;
        public ServicesController(CorporxDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ServiceAsync()
        {
            ServiceViewModel model = new ServiceViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Our Services"),
                Services = await _context.Services.Take(6).ToListAsync(),
                Partners = await _context.Partners.ToListAsync(),
                Promo = await _context.Services.Where(p=>p.IsPromoServ).ToListAsync(),
                Setting = await _context.Settings.FirstOrDefaultAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ServiceAsync(ContactUs contact)
        {
            if (ModelState.IsValid)
            {
                ContactUs message = new ContactUs
                {
                    Fullname = contact.Fullname,
                    Email = contact.Email,
                    Message = contact.Message
                };
                await _context.Contacts.AddAsync(message);
                await _context.SaveChangesAsync();
                return RedirectToAction("Service", "Services");
            }

            return RedirectToAction("Service", "Services");
        }

    }
}

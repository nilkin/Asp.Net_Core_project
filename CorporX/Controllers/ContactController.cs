using System.Threading.Tasks;
using CorporX.Data;
using CorporX.Models;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CorporX.Controllers
{
    public class ContactController : Controller
    {
        private readonly CorporxDbContext _context;
        public ContactController(CorporxDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ContactUsAsync()
        {
            ContactViewModel model = new ContactViewModel
            {
                Sett = await _context.Settings.FirstOrDefaultAsync(),
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Contact Us"),
                Setting = await _context.Settings.FirstOrDefaultAsync()

            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ContactUsAsync(ContactUs contact)
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
                return RedirectToAction("ContactUs", "Contact");
            }

            return RedirectToAction("ContactUs", "Contact");
        }
    }
}

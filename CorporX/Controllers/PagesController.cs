using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CorporX.Controllers
{
    public class PagesController : Controller
    {
        private readonly CorporxDbContext _context;
        public PagesController(CorporxDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> DetailsAsync()
        {
            ServDetailsViewModel model = new ServDetailsViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Services Details"),
                Details = await _context.Services.FirstOrDefaultAsync(s=>s.Text!=null),
                Sett = await _context.Settings.FirstOrDefaultAsync(),
            };
            return View(model);
        }

        public async Task<IActionResult> FagAsync()
        {
            FaqViewModel model = new FaqViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "FAQ Page"),
                Fags = await _context.Faqs.ToListAsync(),
            };
            return View(model);
        }
    }
}

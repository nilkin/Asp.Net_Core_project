using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Controllers
{
    public class AboutController : Controller
    {
        private readonly CorporxDbContext _context;
        public AboutController(CorporxDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> AboutUsAsync()
        {
            AboutUsViewModel model = new AboutUsViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b=>b.Title=="About Us"),
                Members = await _context.Members.Include(m => m.MemberLinks).Take(3).ToListAsync(),
                Promos = await _context.Services.Where(s => s.IsPromoAbout).Take(3).ToListAsync(),
                Abouts = await _context.AboutUs.Skip(1).FirstOrDefaultAsync(),
                Deliver = await _context.Services.Where(s => s.IsDeliver).Take(4).ToListAsync(),
                Clients = await _context.Clients.OrderByDescending(s => s.Id).Take(4).ToListAsync(),
                Partners = await _context.Partners.ToListAsync(),
            };
            return View(model);
        }

    }
}

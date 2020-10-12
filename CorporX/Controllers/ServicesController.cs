using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}

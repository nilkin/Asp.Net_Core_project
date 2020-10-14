
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Controllers
{
    public class HomeController : Controller
    {
        private readonly CorporxDbContext _context;
        public HomeController(CorporxDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var hm = _context.BlogItems.Where(b => !b.IsSidebar).OrderBy(s => s.Id);
            HomeViewModel model = new HomeViewModel
            {

                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "About Us"),
                Heroes = await _context.Heroes.FirstOrDefaultAsync(),
                Promos = await _context.Services.Where(s => s.IsPromoHome).Take(3).ToListAsync(),
                About = await _context.AboutUs.FirstOrDefaultAsync(),
                HomeServices = await _context.Services.OrderByDescending(s=>s.Id).Take(6).ToListAsync(),
                Projects = await _context.Projects.OrderByDescending(s => s.Id).ToListAsync(),
                Clients = await _context.Clients.OrderByDescending(s => s.Id).Take(3).ToListAsync(),
                Members = await _context.Members.Include(m=>m.MemberLinks).Take(3).ToListAsync(),
                PagingList = await PagingList.CreateAsync(hm,3,1)
        };
            return View(model);
        }

    }
} 

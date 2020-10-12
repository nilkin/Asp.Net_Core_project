using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CorporX.Controllers
{
    public class BlogController : Controller
    {
        private readonly CorporxDbContext _context;
        public BlogController(CorporxDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> GridAsync()
        {
            BlogItemsViewModel model = new BlogItemsViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Blog Default"),
                BlogItems = await _context.BlogItems.Where(b => !b.IsSidebar).OrderByDescending(s => s.Id).Take(6).ToListAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> SidebarAsync()
        {
            SidebarViewModel model = new SidebarViewModel
            {
                BlogItem = await _context.BlogItems.FirstOrDefaultAsync(b => b.IsSidebar),
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Blog Left Sidebar"),
            };
            return View(model);
        }
    }
}

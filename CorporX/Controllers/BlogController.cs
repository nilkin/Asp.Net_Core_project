using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace CorporX.Controllers
{
    public class BlogController : Controller
    {
        private readonly CorporxDbContext _context;
        public BlogController(CorporxDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index(int page = 1, int pageSize = 3)
        {
            var items = _context.BlogItems.Where(b => !b.IsSidebar).AsNoTracking().OrderBy(x => x.Id);
            var pagingData = await PagingList.CreateAsync(items ,pageSize , page);
            BlogItemsViewModel model = new BlogItemsViewModel
            {
                PagingList = pagingData,
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Blog Default"),
                
            };
           
            return View(model);
        }
        public async Task<IActionResult> SidebarAsync()
        {
            SidebarViewModel model = new SidebarViewModel
            {
                BlogItem = await _context.BlogItems.FirstOrDefaultAsync(b => b.IsSidebar),
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Blog Single Left Sidebar"),
            };
            return View(model);
        }

        public IActionResult Chat()
        {
            return View();
        }
    }
}

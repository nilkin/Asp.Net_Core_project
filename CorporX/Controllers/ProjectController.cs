using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CorporX.Controllers
{
    public class ProjectController : Controller
    {
        private readonly CorporxDbContext _context;
        public ProjectController(CorporxDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ProjectDetailsAsync()
        {
            ProjectViewModel model = new ProjectViewModel
            {
                Breadcrumb = await _context.Breadcrumbs.FirstOrDefaultAsync(b => b.Title == "Our Projects"),
                Projects = await _context.Projects.OrderByDescending(s => s.Id).ToListAsync(),
                Clients = await _context.Clients.OrderByDescending(s => s.Id).Take(3).ToListAsync(),
                Partners = await _context.Partners.ToListAsync(),
                Packages = await _context.Packages.OrderByDescending(p=>p.Id).ToListAsync(),
            };
            return View(model);

        }
    }
}

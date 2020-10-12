using CorporX.Data;
using CorporX.Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CorporX.ViewComponents
{
    public class FooterComponent : ViewComponent
    {
        private readonly CorporxDbContext _context;
        public FooterComponent(CorporxDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var setting = await _context.Settings.FirstOrDefaultAsync();
            return View(setting);
        }
    }
}

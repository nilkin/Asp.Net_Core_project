using CorporX.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CorporX.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
        private readonly CorporxDbContext _context;
        public HeaderComponent(CorporxDbContext context)
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

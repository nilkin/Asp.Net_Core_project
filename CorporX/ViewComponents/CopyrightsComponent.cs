using CorporX.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewComponents
{
    public class CopyrightsComponent : ViewComponent
    {
        private readonly CorporxDbContext _context;
        public CopyrightsComponent(CorporxDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var setting = await _context.SocialLinks.OrderBy(s=>s.Name).ToListAsync();
            return View(setting);
        }
    }
}

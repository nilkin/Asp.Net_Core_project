using CorporX.Data;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ErrorController : Controller
    {
        private readonly CorporxDbContext _context;
        public ErrorController(CorporxDbContext context)
        {
            _context = context;
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}

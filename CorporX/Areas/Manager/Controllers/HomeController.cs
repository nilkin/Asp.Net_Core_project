using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using Microsoft.AspNetCore.Mvc;
using CorporX.Filters;
namespace CorporX.Areas.Manager.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Manager")]
    public class HomeController : Controller
    {
        private readonly CorporxDbContext _context;

        public HomeController(CorporxDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

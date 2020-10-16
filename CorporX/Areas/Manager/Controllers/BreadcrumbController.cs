using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Data.Models;
using static CorporX.Services.FileUploader;
using System.IO;
using CorporX.Filters;
namespace CorporX.Areas.Manager.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Manager")]
    public class BreadcrumbController : Controller
    {
        private readonly CorporxDbContext _context;
        private readonly IFileManager _fileManager;
        public BreadcrumbController(CorporxDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Manager/Breadcrumb
        public async Task<IActionResult> Index()
        {
            return View(await _context.Breadcrumbs.ToListAsync());
        }

        // GET: Manager/Breadcrumb/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var breadcrumb = await _context.Breadcrumbs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (breadcrumb == null)
            {
                return NotFound();
            }

            return View(breadcrumb);
        }

        // GET: Manager/Breadcrumb/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manager/Breadcrumb/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Photo,Link,Path,Upload")] Breadcrumb breadcrumb)
        {
            if (breadcrumb.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (breadcrumb.Upload.ContentType != "image/jpeg" && breadcrumb.Upload.ContentType != "image/png" && breadcrumb.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (breadcrumb.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }


            if (ModelState.IsValid)
            {
                breadcrumb.Photo = _fileManager.Upload(breadcrumb.Upload, "wwwroot/uploads");
                _context.Add(breadcrumb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(breadcrumb);
        }

        // GET: Manager/Breadcrumb/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var breadcrumb = await _context.Breadcrumbs.FindAsync(id);
            if (breadcrumb == null)
            {
                return NotFound();
            }
            return View(breadcrumb);
        }

        // POST: Manager/Breadcrumb/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Photo,Link,Path,Upload")] Breadcrumb breadcrumb)
        {
            if (id != breadcrumb.Id)
            {
                return NotFound();
            }
            if (breadcrumb.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (breadcrumb.Upload.ContentType != "image/jpeg" && breadcrumb.Upload.ContentType != "image/png"
                 && breadcrumb.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (breadcrumb.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                _fileManager.Delete(breadcrumb.Photo);
                breadcrumb.Photo = _fileManager.Upload(breadcrumb.Upload);

                _context.Entry(breadcrumb).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(breadcrumb);
        }

        // GET: Manager/Breadcrumb/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var breadcrumb = await _context.Breadcrumbs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (breadcrumb == null)
            {
                return NotFound();
            }

            return View(breadcrumb);
        }

        // POST: Manager/Breadcrumb/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutUs = await _context.Breadcrumbs.FindAsync(id);
            try
            {
                _fileManager.Delete(aboutUs.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.Breadcrumbs.Remove(aboutUs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.Breadcrumbs.Remove(aboutUs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BreadcrumbExists(int id)
        {
            return _context.Breadcrumbs.Any(e => e.Id == id);
        }
    }
}

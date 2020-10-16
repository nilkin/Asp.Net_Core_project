using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Data.Models.Entities;
using static CorporX.Services.FileUploader;
using CorporX.Filters;

namespace CorporX.Areas.Manager.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Manager")]
    public class SettingsController : Controller
    {
        private readonly CorporxDbContext _context;
        private readonly IFileManager _fileManager;
        public SettingsController(CorporxDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Manager/Settings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Settings.ToListAsync());
        }

        // GET: Manager/Settings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setting = await _context.Settings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (setting == null)
            {
                return NotFound();
            }

            return View(setting);
        }

        // GET: Manager/Settings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manager/Settings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Logo,Email,Address,Phone,Upload")] Setting setting)
        {
            if (setting.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (setting.Upload.ContentType != "image/jpeg" && setting.Upload.ContentType != "image/png" && setting.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (setting.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                setting.Logo = _fileManager.Upload(setting.Upload, "wwwroot/uploads");
                _context.Add(setting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(setting);
        }

        // GET: Manager/Settings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setting = await _context.Settings.FindAsync(id);
            if (setting == null)
            {
                return NotFound();
            }
            return View(setting);
        }

        // POST: Manager/Settings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Email,Address,Phone,Upload")] Setting setting)
        {
            if (id != setting.Id)
            {
                return NotFound();
            }
            if (setting.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (setting.Upload.ContentType != "image/jpeg" && setting.Upload.ContentType != "image/png"
                 && setting.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (setting.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _fileManager.Delete(setting.Logo);
                    setting.Logo = _fileManager.Upload(setting.Upload);
                    _context.Update(setting).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SettingExists(setting.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(setting);
        }

        // GET: Manager/Settings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setting = await _context.Settings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (setting == null)
            {
                return NotFound();
            }

            return View(setting);
        }

        // POST: Manager/Settings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var setting = await _context.Settings.FindAsync(id);
            try
            {
                _fileManager.Delete(setting.Logo);
            }
            catch (FileNotFoundException)
            {
                _context.Settings.Remove(setting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.Settings.Remove(setting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SettingExists(int id)
        {
            return _context.Settings.Any(e => e.Id == id);
        }
    }
}

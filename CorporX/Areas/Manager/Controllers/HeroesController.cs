using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Models;
using static CorporX.Services.FileUploader;
using System.IO;
using CorporX.Filters;
namespace CorporX.Areas.Manager.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Manager")]
    public class HeroesController : Controller
    {
        private readonly CorporxDbContext _context;
        private readonly IFileManager _fileManager;
        public HeroesController(CorporxDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Manager/Heroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Heroes.ToListAsync());
        }

        // GET: Manager/Heroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Heroes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // GET: Manager/Heroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manager/Heroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Heading,Photo,Id,Name,Content,Upload")] Hero hero)
        {
            if (hero.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (hero.Upload.ContentType != "image/jpeg" && hero.Upload.ContentType != "image/png" && hero.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (hero.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }


            if (ModelState.IsValid)
            {
                hero.Photo = _fileManager.Upload(hero.Upload, "wwwroot/uploads");
                _context.Add(hero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hero);
        }

        // GET: Manager/Heroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Heroes.FindAsync(id);
            if (hero == null)
            {
                return NotFound();
            }
            return View(hero);
        }

        // POST: Manager/Heroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Heading,Photo,Id,Name,Content,Upload")] Hero hero)
        {
            if (id != hero.Id)
            {
                return NotFound();
            }
            if (hero.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (hero.Upload.ContentType != "image/jpeg" && hero.Upload.ContentType != "image/png"
                 && hero.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (hero.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(hero.Photo);
                    hero.Photo = _fileManager.Upload(hero.Upload);
                    _context.Update(hero).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeroExists(hero.Id))
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
            return View(hero);
        }

        // GET: Manager/Heroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Heroes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // POST: Manager/Heroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hero = await _context.Heroes.FindAsync(id);
            try
            {
                _fileManager.Delete(hero.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.Heroes.Remove(hero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeroExists(int id)
        {
            return _context.Heroes.Any(e => e.Id == id);
        }
    }
}

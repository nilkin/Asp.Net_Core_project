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
    public class PartnersController : Controller
    {
        private readonly CorporxDbContext _context;
        private readonly IFileManager _fileManager;
        public PartnersController(CorporxDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Manager/Partners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Partners.ToListAsync());
        }

        // GET: Manager/Partners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // GET: Manager/Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manager/Partners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Photo,Url,Upload")] Partner partner)
        {
            if (partner.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (partner.Upload.ContentType != "image/jpeg" && partner.Upload.ContentType != "image/png" && partner.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (partner.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }


            if (ModelState.IsValid)
            {
                partner.Photo = _fileManager.Upload(partner.Upload, "wwwroot/uploads");
                _context.Add(partner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }

        // GET: Manager/Partners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FindAsync(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: Manager/Partners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Photo,Url,Upload")] Partner partner)
        {
            if (id != partner.Id)
            {
                return NotFound();
            }
            if (partner.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (partner.Upload.ContentType != "image/jpeg" && partner.Upload.ContentType != "image/png"
                 && partner.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (partner.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(partner.Photo);
                    partner.Photo = _fileManager.Upload(partner.Upload);
                    _context.Update(partner).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartnerExists(partner.Id))
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
            return View(partner);
        }

        // GET: Manager/Partners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // POST: Manager/Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partner = await _context.Partners.FindAsync(id);
            try
            {
                _fileManager.Delete(partner.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.Partners.Remove(partner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.Partners.Remove(partner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartnerExists(int id)
        {
            return _context.Partners.Any(e => e.Id == id);
        }
    }
}

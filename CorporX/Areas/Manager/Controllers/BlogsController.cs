using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Models;
using static CorporX.Services.FileUploader;
using System.IO;

namespace CorporX.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class BlogsController : Controller
    {
        private readonly CorporxDbContext _context;
        private readonly IFileManager _fileManager;
        public BlogsController(CorporxDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Manager/Blogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogItems.ToListAsync());
        }

        // GET: Manager/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogItem = await _context.BlogItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogItem == null)
            {
                return NotFound();
            }

            return View(blogItem);
        }

        // GET: Manager/Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manager/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Text,Photo,AddedDate,BlogType,IsSidebar,Id,Name,Content,Upload")] BlogItem blogItem)
        {
            if (blogItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (blogItem.Upload.ContentType != "image/jpeg" && blogItem.Upload.ContentType != "image/png" && blogItem.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (blogItem.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }


            if (ModelState.IsValid)
            {
                blogItem.Photo = _fileManager.Upload(blogItem.Upload, "wwwroot/uploads");
                _context.Add(blogItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogItem);
        }

        // GET: Manager/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogItem = await _context.BlogItems.FindAsync(id);
            if (blogItem == null)
            {
                return NotFound();
            }
            return View(blogItem);
        }

        // POST: Manager/Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("Text,Photo,AddedDate,BlogType,IsSidebar,Id,Name,Content,Upload")] BlogItem blogItem)
        {
            //string file = _context.BlogItems.Find(blogItem.Id).Photo;
            if (id != blogItem.Id)
            {
                return NotFound();
            }
            if (blogItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (blogItem.Upload.ContentType != "image/jpeg" && blogItem.Upload.ContentType != "image/png"
                 && blogItem.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (blogItem.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
          
            if (ModelState.IsValid)
            {
                try
                {

                    _fileManager.Delete(blogItem.Photo);
                    blogItem.Photo = _fileManager.Upload(blogItem.Upload);
                    _context.Update(blogItem).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogItemExists(blogItem.Id))
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
            return View(blogItem);
        }

        // GET: Manager/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blogItem = await _context.BlogItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogItem == null)
            {
                return NotFound();
            }
            return View(blogItem);
        }
        // POST: Admin/Heroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogItem = await _context.BlogItems.FindAsync(id);
            try
            {
                _fileManager.Delete(blogItem.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.BlogItems.Remove(blogItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.BlogItems.Remove(blogItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool BlogItemExists(int id)
        {
            return _context.BlogItems.Any(e => e.Id == id);
        }
    }
}

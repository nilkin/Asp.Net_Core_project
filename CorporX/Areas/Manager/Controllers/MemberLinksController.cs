using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Models;
using CorporX.Filters;

namespace CorporX.Areas.Manager.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Manager")]
    public class MemberLinksController : Controller
    {
        private readonly CorporxDbContext _context;

        public MemberLinksController(CorporxDbContext context)
        {
            _context = context;
        }

        // GET: Manager/MemberLinks
        public async Task<IActionResult> Index()
        {
            var corporxDbContext = _context.MemberLinks.Include(m => m.Member);
            return View(await corporxDbContext.ToListAsync());
        }

        // GET: Manager/MemberLinks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberLink = await _context.MemberLinks
                .Include(m => m.Member)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memberLink == null)
            {
                return NotFound();
            }

            return View(memberLink);
        }

        // GET: Manager/MemberLinks/Create
        public IActionResult Create()
        {
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name");
            return View();
        }

        // POST: Manager/MemberLinks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MemberId,ClassName,Url")] MemberLink memberLink)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memberLink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name", memberLink.MemberId);
            return View(memberLink);
        }

        // GET: Manager/MemberLinks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberLink = await _context.MemberLinks.FindAsync(id);
            if (memberLink == null)
            {
                return NotFound();
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name", memberLink.MemberId);
            return View(memberLink);
        }

        // POST: Manager/MemberLinks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MemberId,ClassName,Url")] MemberLink memberLink)
        {
            if (id != memberLink.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memberLink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberLinkExists(memberLink.Id))
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
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name", memberLink.MemberId);
            return View(memberLink);
        }

        // GET: Manager/MemberLinks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberLink = await _context.MemberLinks
                .Include(m => m.Member)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memberLink == null)
            {
                return NotFound();
            }

            return View(memberLink);
        }

        // POST: Manager/MemberLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var memberLink = await _context.MemberLinks.FindAsync(id);
            _context.MemberLinks.Remove(memberLink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberLinkExists(int id)
        {
            return _context.MemberLinks.Any(e => e.Id == id);
        }
    }
}

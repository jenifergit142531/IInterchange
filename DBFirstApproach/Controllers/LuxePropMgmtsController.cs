using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBFirstApproach.Models;

namespace DBFirstApproach.Controllers
{
    public class LuxePropMgmtsController : Controller
    {
        private readonly PropcareContext _context;

        public LuxePropMgmtsController(PropcareContext context)
        {
            _context = context;
        }

        // GET: LuxePropMgmts
        public async Task<IActionResult> Index()
        {
              return _context.LuxePropMgmts != null ? 
                          View(await _context.LuxePropMgmts.ToListAsync()) :
                          Problem("Entity set 'PropcareContext.LuxePropMgmts'  is null.");
        }

        // GET: LuxePropMgmts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.LuxePropMgmts == null)
            {
                return NotFound();
            }

            var luxePropMgmt = await _context.LuxePropMgmts
                .FirstOrDefaultAsync(m => m.Propid == id);
            if (luxePropMgmt == null)
            {
                return NotFound();
            }

            return View(luxePropMgmt);
        }

        // GET: LuxePropMgmts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LuxePropMgmts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Propid,Pname,Partnername,Address,Service,Requesteddate,Duration")] LuxePropMgmt luxePropMgmt)
        {
            if (ModelState.IsValid)
            {
                luxePropMgmt.Propid = Guid.NewGuid();
                _context.Add(luxePropMgmt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(luxePropMgmt);
        }

        // GET: LuxePropMgmts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.LuxePropMgmts == null)
            {
                return NotFound();
            }

            var luxePropMgmt = await _context.LuxePropMgmts.FindAsync(id);
            if (luxePropMgmt == null)
            {
                return NotFound();
            }
            return View(luxePropMgmt);
        }

        // POST: LuxePropMgmts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Propid,Pname,Partnername,Address,Service,Requesteddate,Duration")] LuxePropMgmt luxePropMgmt)
        {
            if (id != luxePropMgmt.Propid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(luxePropMgmt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LuxePropMgmtExists(luxePropMgmt.Propid))
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
            return View(luxePropMgmt);
        }

        // GET: LuxePropMgmts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.LuxePropMgmts == null)
            {
                return NotFound();
            }

            var luxePropMgmt = await _context.LuxePropMgmts
                .FirstOrDefaultAsync(m => m.Propid == id);
            if (luxePropMgmt == null)
            {
                return NotFound();
            }

            return View(luxePropMgmt);
        }

        // POST: LuxePropMgmts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.LuxePropMgmts == null)
            {
                return Problem("Entity set 'PropcareContext.LuxePropMgmts'  is null.");
            }
            var luxePropMgmt = await _context.LuxePropMgmts.FindAsync(id);
            if (luxePropMgmt != null)
            {
                _context.LuxePropMgmts.Remove(luxePropMgmt);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LuxePropMgmtExists(Guid id)
        {
          return (_context.LuxePropMgmts?.Any(e => e.Propid == id)).GetValueOrDefault();
        }
    }
}

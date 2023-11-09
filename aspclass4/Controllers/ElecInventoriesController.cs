using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aspclass4.Models;

namespace aspclass4.Controllers
{
    public class ElecInventoriesController : Controller
    {
        private readonly MydbfirstContext _context;

        public ElecInventoriesController(MydbfirstContext context)
        {
            _context = context;
        }

        // GET: ElecInventories
        public async Task<IActionResult> Index()
        {
              return _context.ElecInventories != null ? 
                          View(await _context.ElecInventories.ToListAsync()) :
                          Problem("Entity set 'MydbfirstContext.ElecInventories'  is null.");
        }

        // GET: ElecInventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ElecInventories == null)
            {
                return NotFound();
            }

            var elecInventory = await _context.ElecInventories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elecInventory == null)
            {
                return NotFound();
            }

            return View(elecInventory);
        }

        // GET: ElecInventories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ElecInventories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pname,Price,Quantity,Updateddate")] ElecInventory elecInventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(elecInventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(elecInventory);
        }

        // GET: ElecInventories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ElecInventories == null)
            {
                return NotFound();
            }

            var elecInventory = await _context.ElecInventories.FindAsync(id);
            if (elecInventory == null)
            {
                return NotFound();
            }
            return View(elecInventory);
        }

        // POST: ElecInventories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pname,Price,Quantity,Updateddate")] ElecInventory elecInventory)
        {
            if (id != elecInventory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(elecInventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElecInventoryExists(elecInventory.Id))
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
            return View(elecInventory);
        }

        // GET: ElecInventories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ElecInventories == null)
            {
                return NotFound();
            }

            var elecInventory = await _context.ElecInventories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elecInventory == null)
            {
                return NotFound();
            }

            return View(elecInventory);
        }

        // POST: ElecInventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ElecInventories == null)
            {
                return Problem("Entity set 'MydbfirstContext.ElecInventories'  is null.");
            }
            var elecInventory = await _context.ElecInventories.FindAsync(id);
            if (elecInventory != null)
            {
                _context.ElecInventories.Remove(elecInventory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ElecInventoryExists(int id)
        {
          return (_context.ElecInventories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

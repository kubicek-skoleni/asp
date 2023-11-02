using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelefonniSeznam.Data;
using TelefonniSeznam.Models;

namespace TelefonniSeznam.Controllers
{
    public class SeznamController : Controller
    {
        private readonly SeznamDbContext _context;

        public SeznamController(SeznamDbContext context)
        {
            _context = context;
        }

        // GET: Seznam
        public async Task<IActionResult> Index()
        {
              return _context.Lide != null ? 
                          View(await _context.Lide.ToListAsync()) :
                          Problem("Entity set 'SeznamDbContext.Lide'  is null.");
        }

        // GET: Seznam/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lide == null)
            {
                return NotFound();
            }

            var clovek = await _context.Lide
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clovek == null)
            {
                return NotFound();
            }

            return View(clovek);
        }

        // GET: Seznam/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Seznam/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Jmeno,Prijmeni,Telefon")] Clovek clovek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clovek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clovek);
        }

        // GET: Seznam/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lide == null)
            {
                return NotFound();
            }

            var clovek = await _context.Lide.FindAsync(id);
            if (clovek == null)
            {
                return NotFound();
            }
            return View(clovek);
        }

        // POST: Seznam/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Jmeno,Prijmeni,DatumNarozeni,Telefon")] Clovek clovek)
        {
            if (id != clovek.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clovek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClovekExists(clovek.Id))
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
            return View(clovek);
        }

        // GET: Seznam/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lide == null)
            {
                return NotFound();
            }

            var clovek = await _context.Lide
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clovek == null)
            {
                return NotFound();
            }

            return View(clovek);
        }

        // POST: Seznam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lide == null)
            {
                return Problem("Entity set 'SeznamDbContext.Lide'  is null.");
            }
            var clovek = await _context.Lide.FindAsync(id);
            if (clovek != null)
            {
                _context.Lide.Remove(clovek);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClovekExists(int id)
        {
          return (_context.Lide?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

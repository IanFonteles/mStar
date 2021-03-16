using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupplyApplication.Models;

namespace SupplyApplication.Controllers
{
    public class ProductEntriesController : Controller
    {
        private readonly ProjectContext _context;

        public ProductEntriesController(ProjectContext context)
        {
            _context = context;
        }

        // GET: ProductEntries
        public async Task<IActionResult> Index()
        {
            var projectContext = _context.ProductEntry.Include(p => p.Product);
            return View(await projectContext.ToListAsync());
        }

        // GET: ProductEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productEntry = await _context.ProductEntry
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productEntry == null)
            {
                return NotFound();
            }

            return View(productEntry);
        }

        // GET: ProductEntries/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description");
            return View();
        }

        // POST: ProductEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,InventoryQuantity,ProductId")] ProductEntry productEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", productEntry.ProductId);
            return View(productEntry);
        }

        // GET: ProductEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productEntry = await _context.ProductEntry.FindAsync(id);
            if (productEntry == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", productEntry.ProductId);
            return View(productEntry);
        }

        // POST: ProductEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,InventoryQuantity,ProductId")] ProductEntry productEntry)
        {
            if (id != productEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductEntryExists(productEntry.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", productEntry.ProductId);
            return View(productEntry);
        }

        // GET: ProductEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productEntry = await _context.ProductEntry
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productEntry == null)
            {
                return NotFound();
            }

            return View(productEntry);
        }

        // POST: ProductEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productEntry = await _context.ProductEntry.FindAsync(id);
            _context.ProductEntry.Remove(productEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductEntryExists(int id)
        {
            return _context.ProductEntry.Any(e => e.Id == id);
        }
    }
}

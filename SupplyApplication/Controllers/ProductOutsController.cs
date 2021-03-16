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
    public class ProductOutsController : Controller
    {
        private readonly ProjectContext _context;

        public ProductOutsController(ProjectContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var projectContext = _context.ProductOut.Include(p => p.Product);
            return View(await projectContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOut = await _context.ProductOut
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productOut == null)
            {
                return NotFound();
            }

            return View(productOut);
        }

        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,InventoryQuantity,ProductId")] ProductOut productOut)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productOut);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", productOut.ProductId);
            return View(productOut);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOut = await _context.ProductOut.FindAsync(id);
            if (productOut == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", productOut.ProductId);
            return View(productOut);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,InventoryQuantity,ProductId")] ProductOut productOut)
        {
            if (id != productOut.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productOut);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductOutExists(productOut.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", productOut.ProductId);
            return View(productOut);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOut = await _context.ProductOut
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productOut == null)
            {
                return NotFound();
            }

            return View(productOut);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productOut = await _context.ProductOut.FindAsync(id);
            _context.ProductOut.Remove(productOut);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductOutExists(int id)
        {
            return _context.ProductOut.Any(e => e.Id == id);
        }
    }
}

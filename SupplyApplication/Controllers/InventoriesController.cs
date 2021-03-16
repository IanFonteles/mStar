using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupplyApplication.Models;

namespace SupplyApplication.Controllers {
    public class InventoriesController : Controller {
        private readonly ProjectContext _context;

        public InventoriesController(ProjectContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            var projectContext = _context.Inventories.Include(i => i.Product);
            return View(await projectContext.ToListAsync());
        }

        public IActionResult Create() {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product,ProductEntry entry,ProductOut r) {

            //pegando o produto

            var prod = _context.Inventories.First(p => p.ProductId == product.Id);
            _context.Inventories.Add(prod);
            var entrando = _context.ProductEntry.Select(p => p.ProductId == product.Id).Count(entry.InventoryQuantity);
            var saindo = _context.ProductEntry.Select(p => p.ProductId == product.Id).Count(r.InventoryQuantity);

            prod.InventoryQuantity = entrando - saindo;


            if (ModelState.IsValid) {
                _context.Add(prod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", prod.ProductId);
            return View(prod);
        }
    }
}


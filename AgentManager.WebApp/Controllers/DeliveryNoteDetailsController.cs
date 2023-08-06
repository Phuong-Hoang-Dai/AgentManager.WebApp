using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgentManager.WebApp.Models.Data;

namespace AgentManager.WebApp.Controllers
{
    public class DeliveryNoteDetailsController : Controller
    {
        private readonly AgentManagerDbContext _context;

        public DeliveryNoteDetailsController(AgentManagerDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryNoteDetails
        public async Task<IActionResult> Index()
        {
            var agentManagerDbContext = _context.DeliveryNoteDetails.Include(d => d.DeliveryNote).Include(d => d.Product);
            return View(await agentManagerDbContext.ToListAsync());
        }

        // GET: DeliveryNoteDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DeliveryNoteDetails == null)
            {
                return NotFound();
            }

            var deliveryNoteDetail = await _context.DeliveryNoteDetails
                .Include(d => d.DeliveryNote)
                .Include(d => d.Product)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (deliveryNoteDetail == null)
            {
                return NotFound();
            }

            return View(deliveryNoteDetail);
        }

        // GET: DeliveryNoteDetails/Create
        public IActionResult Create()
        {
            ViewData["DeliveryNoteId"] = new SelectList(_context.DeliveryNotes, "DeliveryNoteId", "DeliveryNoteId");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
            return View();
        }

        // POST: DeliveryNoteDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Quantity,Price,ProductId,DeliveryNoteId")] DeliveryNoteDetail deliveryNoteDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryNoteDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeliveryNoteId"] = new SelectList(_context.DeliveryNotes, "DeliveryNoteId", "DeliveryNoteId", deliveryNoteDetail.DeliveryNoteId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", deliveryNoteDetail.ProductId);
            return View(deliveryNoteDetail);
        }

        // GET: DeliveryNoteDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DeliveryNoteDetails == null)
            {
                return NotFound();
            }

            var deliveryNoteDetail = await _context.DeliveryNoteDetails.FindAsync(id);
            if (deliveryNoteDetail == null)
            {
                return NotFound();
            }
            ViewData["DeliveryNoteId"] = new SelectList(_context.DeliveryNotes, "DeliveryNoteId", "DeliveryNoteId", deliveryNoteDetail.DeliveryNoteId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", deliveryNoteDetail.ProductId);
            return View(deliveryNoteDetail);
        }

        // POST: DeliveryNoteDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Quantity,Price,ProductId,DeliveryNoteId")] DeliveryNoteDetail deliveryNoteDetail)
        {
            if (id != deliveryNoteDetail.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryNoteDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryNoteDetailExists(deliveryNoteDetail.ProductId))
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
            ViewData["DeliveryNoteId"] = new SelectList(_context.DeliveryNotes, "DeliveryNoteId", "DeliveryNoteId", deliveryNoteDetail.DeliveryNoteId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", deliveryNoteDetail.ProductId);
            return View(deliveryNoteDetail);
        }

        // GET: DeliveryNoteDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DeliveryNoteDetails == null)
            {
                return NotFound();
            }

            var deliveryNoteDetail = await _context.DeliveryNoteDetails
                .Include(d => d.DeliveryNote)
                .Include(d => d.Product)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (deliveryNoteDetail == null)
            {
                return NotFound();
            }

            return View(deliveryNoteDetail);
        }

        // POST: DeliveryNoteDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DeliveryNoteDetails == null)
            {
                return Problem("Entity set 'AgentManagerDbContext.DeliveryNoteDetails'  is null.");
            }
            var deliveryNoteDetail = await _context.DeliveryNoteDetails.FindAsync(id);
            if (deliveryNoteDetail != null)
            {
                _context.DeliveryNoteDetails.Remove(deliveryNoteDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryNoteDetailExists(int id)
        {
          return (_context.DeliveryNoteDetails?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}

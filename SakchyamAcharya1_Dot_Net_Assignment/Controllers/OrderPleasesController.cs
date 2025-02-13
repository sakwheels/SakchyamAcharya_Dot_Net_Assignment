using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SakchyamAcharya1_Dot_Net_Assignment.Data;
using SakchyamAcharya1_Dot_Net_Assignment.Models;

namespace SakchyamAcharya1_Dot_Net_Assignment.Controllers
{
    public class OrderPleasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderPleasesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrderPleases
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrderPlease.ToListAsync());
        }

        // GET: OrderPleases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPlease = await _context.OrderPlease
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderPlease == null)
            {
                return NotFound();
            }

            return View(orderPlease);
        }

        // GET: OrderPleases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderPleases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerName,ProductName,Quantity,Price,OrderDate")] OrderPlease orderPlease)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderPlease);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderPlease);
        }

        // GET: OrderPleases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPlease = await _context.OrderPlease.FindAsync(id);
            if (orderPlease == null)
            {
                return NotFound();
            }
            return View(orderPlease);
        }

        // POST: OrderPleases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerName,ProductName,Quantity,Price,OrderDate")] OrderPlease orderPlease)
        {
            if (id != orderPlease.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderPlease);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderPleaseExists(orderPlease.Id))
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
            return View(orderPlease);
        }

        // GET: OrderPleases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderPlease = await _context.OrderPlease
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderPlease == null)
            {
                return NotFound();
            }

            return View(orderPlease);
        }

        // POST: OrderPleases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderPlease = await _context.OrderPlease.FindAsync(id);
            if (orderPlease != null)
            {
                _context.OrderPlease.Remove(orderPlease);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderPleaseExists(int id)
        {
            return _context.OrderPlease.Any(e => e.Id == id);
        }
    }
}

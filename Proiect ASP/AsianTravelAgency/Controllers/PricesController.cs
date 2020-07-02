using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AsianTravelAgency;
using AsianTravelAgency.Models;

namespace AsianTravelAgency.Controllers
{
    public class PricesController : Controller
    {
        private readonly AsianTravelAgencyContext _context;

        public PricesController(AsianTravelAgencyContext context)
        {
            _context = context;
        }

        // GET: Prices
        public async Task<IActionResult> Index()
        {
            return View(await _context.PriceSet.ToListAsync());
        }

        // GET: Prices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.PriceSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prices == null)
            {
                return NotFound();
            }

            return View(prices);
        }

        // GET: Prices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Destination,OnePersonPrice,TwoPersonsPrice,ThreePersonsPrice,SendingWay,TicketType,Guiding,LeavingFrom,TripInfo")] Prices prices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prices);
        }

        // GET: Prices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.PriceSet.FindAsync(id);
            if (prices == null)
            {
                return NotFound();
            }
            return View(prices);
        }

        // POST: Prices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Destination,OnePersonPrice,TwoPersonsPrice,ThreePersonsPrice,SendingWay,TicketType,Guiding,LeavingFrom,TripInfo")] Prices prices)
        {
            if (id != prices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PricesExists(prices.Id))
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
            return View(prices);
        }

        // GET: Prices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.PriceSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prices == null)
            {
                return NotFound();
            }

            return View(prices);
        }

        // POST: Prices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prices = await _context.PriceSet.FindAsync(id);
            _context.PriceSet.Remove(prices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PricesExists(int id)
        {
            return _context.PriceSet.Any(e => e.Id == id);
        }
    }
}

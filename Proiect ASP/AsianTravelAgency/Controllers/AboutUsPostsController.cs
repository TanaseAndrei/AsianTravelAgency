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
    public class AboutUsPostsController : Controller
    {
        private readonly AsianTravelAgencyContext _context;

        public AboutUsPostsController(AsianTravelAgencyContext context)
        {
            _context = context;
        }

        // GET: AboutUsPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutUsPostSet.ToListAsync());
        }

        // GET: AboutUsPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsPost = await _context.AboutUsPostSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutUsPost == null)
            {
                return NotFound();
            }

            return View(aboutUsPost);
        }

        // GET: AboutUsPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AboutUsPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,ImageTitle")] AboutUsPost aboutUsPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutUsPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutUsPost);
        }

        // GET: AboutUsPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsPost = await _context.AboutUsPostSet.FindAsync(id);
            if (aboutUsPost == null)
            {
                return NotFound();
            }
            return View(aboutUsPost);
        }

        // POST: AboutUsPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,ImageTitle")] AboutUsPost aboutUsPost)
        {
            if (id != aboutUsPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutUsPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutUsPostExists(aboutUsPost.Id))
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
            return View(aboutUsPost);
        }

        // GET: AboutUsPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsPost = await _context.AboutUsPostSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutUsPost == null)
            {
                return NotFound();
            }

            return View(aboutUsPost);
        }

        // POST: AboutUsPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutUsPost = await _context.AboutUsPostSet.FindAsync(id);
            _context.AboutUsPostSet.Remove(aboutUsPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutUsPostExists(int id)
        {
            return _context.AboutUsPostSet.Any(e => e.Id == id);
        }
    }
}

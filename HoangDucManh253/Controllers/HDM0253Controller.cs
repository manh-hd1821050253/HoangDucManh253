using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangDucManh253.Data;
using HoangDucManh253.Models;

namespace HoangDucManh253.Controllers
{
    public class HDM0253Controller : Controller
    {
        private readonly HoangDucManh253Context _context;

        public HDM0253Controller(HoangDucManh253Context context)
        {
            _context = context;
        }

        // GET: HDM0253
        public async Task<IActionResult> Index()
        {
            return View(await _context.HDM0253.ToListAsync());
        }

        // GET: HDM0253/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDM0253 = await _context.HDM0253
                .FirstOrDefaultAsync(m => m.HDMId == id);
            if (hDM0253 == null)
            {
                return NotFound();
            }

            return View(hDM0253);
        }

        // GET: HDM0253/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HDM0253/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HDMId,HDMName,HDMGender")] HDM0253 hDM0253)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hDM0253);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hDM0253);
        }

        // GET: HDM0253/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDM0253 = await _context.HDM0253.FindAsync(id);
            if (hDM0253 == null)
            {
                return NotFound();
            }
            return View(hDM0253);
        }

        // POST: HDM0253/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HDMId,HDMName,HDMGender")] HDM0253 hDM0253)
        {
            if (id != hDM0253.HDMId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hDM0253);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HDM0253Exists(hDM0253.HDMId))
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
            return View(hDM0253);
        }

        // GET: HDM0253/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDM0253 = await _context.HDM0253
                .FirstOrDefaultAsync(m => m.HDMId == id);
            if (hDM0253 == null)
            {
                return NotFound();
            }

            return View(hDM0253);
        }

        // POST: HDM0253/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hDM0253 = await _context.HDM0253.FindAsync(id);
            _context.HDM0253.Remove(hDM0253);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HDM0253Exists(string id)
        {
            return _context.HDM0253.Any(e => e.HDMId == id);
        }
    }
}

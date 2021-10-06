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
    public class PersonHDM253Controller : Controller
    {
        private readonly HoangDucManh253Context _context;

        public PersonHDM253Controller(HoangDucManh253Context context)
        {
            _context = context;
        }

        // GET: PersonHDM253
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonHDM253.ToListAsync());
        }

        // GET: PersonHDM253/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHDM253 = await _context.PersonHDM253
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personHDM253 == null)
            {
                return NotFound();
            }

            return View(personHDM253);
        }

        // GET: PersonHDM253/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonHDM253/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonHDM253 personHDM253)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personHDM253);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personHDM253);
        }

        // GET: PersonHDM253/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHDM253 = await _context.PersonHDM253.FindAsync(id);
            if (personHDM253 == null)
            {
                return NotFound();
            }
            return View(personHDM253);
        }

        // POST: PersonHDM253/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonHDM253 personHDM253)
        {
            if (id != personHDM253.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personHDM253);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonHDM253Exists(personHDM253.PersonId))
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
            return View(personHDM253);
        }

        // GET: PersonHDM253/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHDM253 = await _context.PersonHDM253
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personHDM253 == null)
            {
                return NotFound();
            }

            return View(personHDM253);
        }

        // POST: PersonHDM253/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personHDM253 = await _context.PersonHDM253.FindAsync(id);
            _context.PersonHDM253.Remove(personHDM253);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonHDM253Exists(string id)
        {
            return _context.PersonHDM253.Any(e => e.PersonId == id);
        }
    }
}

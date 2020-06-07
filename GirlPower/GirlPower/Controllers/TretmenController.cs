using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GirlPower.Models;

namespace GirlPower.Controllers
{
    public class TretmenController : Controller
    {
        private readonly GirlPowerContext _context;

        public TretmenController(GirlPowerContext context)
        {
            _context = context;
        }

        // GET: Tretmen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tretmani.ToListAsync());
        }

        // GET: Tretmen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tretman = await _context.Tretmani
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tretman == null)
            {
                return NotFound();
            }

            return View(tretman);
        }

        // GET: Tretmen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tretmen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OpisTretmana,CijenaTretmana,TrajanjeTretmana,Izvrsen,NazivTretmana,Id")] Tretman tretman)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tretman);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tretman);
        }

        // GET: Tretmen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tretman = await _context.Tretmani.FindAsync(id);
            if (tretman == null)
            {
                return NotFound();
            }
            return View(tretman);
        }

        // POST: Tretmen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OpisTretmana,CijenaTretmana,TrajanjeTretmana,Izvrsen,NazivTretmana,Id")] Tretman tretman)
        {
            if (id != tretman.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tretman);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TretmanExists(tretman.Id))
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
            return View(tretman);
        }

        // GET: Tretmen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tretman = await _context.Tretmani
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tretman == null)
            {
                return NotFound();
            }

            return View(tretman);
        }

        // POST: Tretmen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tretman = await _context.Tretmani.FindAsync(id);
            _context.Tretmani.Remove(tretman);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TretmanExists(int id)
        {
            return _context.Tretmani.Any(e => e.Id == id);
        }
    }
}

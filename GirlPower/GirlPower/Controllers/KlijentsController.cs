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
    public class KlijentsController : Controller
    {
        private readonly GirlPowerContext _context;

        public KlijentsController(GirlPowerContext context)
        {
            _context = context;
        }

        // GET: Klijents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Klijenti.ToListAsync());
        }

        // GET: Klijents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klijent = await _context.Klijenti
                .FirstOrDefaultAsync(m => m.Id == id);
            if (klijent == null)
            {
                return NotFound();
            }

            return View(klijent);
        }

        // GET: Klijents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Klijents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Registrovan,IdKlijenta,Ime,Prezime,KorisnickoIme,Lozinka,EMailTelefon,Id")] Klijent klijent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(klijent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(klijent);
        }

        // GET: Klijents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klijent = await _context.Klijenti.FindAsync(id);
            if (klijent == null)
            {
                return NotFound();
            }
            return View(klijent);
        }

        // POST: Klijents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Registrovan,IdKlijenta,Ime,Prezime,KorisnickoIme,Lozinka,EMailTelefon,Id")] Klijent klijent)
        {
            if (id != klijent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(klijent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KlijentExists(klijent.Id))
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
            return View(klijent);
        }

        // GET: Klijents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klijent = await _context.Klijenti
                .FirstOrDefaultAsync(m => m.Id == id);
            if (klijent == null)
            {
                return NotFound();
            }

            return View(klijent);
        }

        // POST: Klijents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var klijent = await _context.Klijenti.FindAsync(id);
            _context.Klijenti.Remove(klijent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KlijentExists(int id)
        {
            return _context.Klijenti.Any(e => e.Id == id);
        }
    }
}

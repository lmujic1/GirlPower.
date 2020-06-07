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
    public class UposleniksController : Controller
    {
        private readonly GirlPowerContext _context;

        public UposleniksController(GirlPowerContext context)
        {
            _context = context;
        }

        // GET: Uposleniks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Uposlenici.ToListAsync());
        }

        // GET: Uposleniks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uposlenik = await _context.Uposlenici
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uposlenik == null)
            {
                return NotFound();
            }

            return View(uposlenik);
        }

        // GET: Uposleniks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Uposleniks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ime,Prezime,KorisnickoIme,Lozinka,EMailTelefon,Id")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uposlenik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uposlenik);
        }

        // GET: Uposleniks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uposlenik = await _context.Uposlenici.FindAsync(id);
            if (uposlenik == null)
            {
                return NotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposleniks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ime,Prezime,KorisnickoIme,Lozinka,EMailTelefon,Id")] Uposlenik uposlenik)
        {
            if (id != uposlenik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uposlenik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UposlenikExists(uposlenik.Id))
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
            return View(uposlenik);
        }

        // GET: Uposleniks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uposlenik = await _context.Uposlenici
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uposlenik == null)
            {
                return NotFound();
            }

            return View(uposlenik);
        }

        // POST: Uposleniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uposlenik = await _context.Uposlenici.FindAsync(id);
            _context.Uposlenici.Remove(uposlenik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UposlenikExists(int id)
        {
            return _context.Uposlenici.Any(e => e.Id == id);
        }
    }
}

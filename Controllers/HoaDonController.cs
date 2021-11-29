using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HoaDonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HoaDonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HoaDon
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.hoaDons.Include(h => h.khachHangs).Include(h => h.people);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: HoaDon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.hoaDons
                .Include(h => h.khachHangs)
                .Include(h => h.people)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: HoaDon/Create
        public IActionResult Create()
        {
            ViewData["KhachHangId"] = new SelectList(_context.khachHangs, "KhachHangId", "KhachHangId");
            ViewData["PersonId"] = new SelectList(_context.People, "PersonId", "PersonId");
            return View();
        }

        // POST: HoaDon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KhachHangId,PersonId")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KhachHangId"] = new SelectList(_context.khachHangs, "KhachHangId", "KhachHangId", hoaDon.KhachHangId);
            ViewData["PersonId"] = new SelectList(_context.People, "PersonId", "PersonId", hoaDon.PersonId);
            return View(hoaDon);
        }

        // GET: HoaDon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.hoaDons.FindAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["KhachHangId"] = new SelectList(_context.khachHangs, "KhachHangId", "KhachHangId", hoaDon.KhachHangId);
            ViewData["PersonId"] = new SelectList(_context.People, "PersonId", "PersonId", hoaDon.PersonId);
            return View(hoaDon);
        }

        // POST: HoaDon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KhachHangId,PersonId")] HoaDon hoaDon)
        {
            if (id != hoaDon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.Id))
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
            ViewData["KhachHangId"] = new SelectList(_context.khachHangs, "KhachHangId", "KhachHangId", hoaDon.KhachHangId);
            ViewData["PersonId"] = new SelectList(_context.People, "PersonId", "PersonId", hoaDon.PersonId);
            return View(hoaDon);
        }

        // GET: HoaDon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.hoaDons
                .Include(h => h.khachHangs)
                .Include(h => h.people)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // POST: HoaDon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDon = await _context.hoaDons.FindAsync(id);
            _context.hoaDons.Remove(hoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonExists(int id)
        {
            return _context.hoaDons.Any(e => e.Id == id);
        }
    }
}

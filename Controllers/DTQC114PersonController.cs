using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DTQC_BaiThi2324.Data;
using DTQC_BaiThi2324.Models;

namespace DTQC_BaiThi2324.Controllers
{
    public class DTQC114PersonController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public DTQC114PersonController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: DTQC114Person
        public async Task<IActionResult> Index()
        {
            return View(await _context.DTQC114Person.ToListAsync());
        }

        // GET: DTQC114Person/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Person = await _context.DTQC114Person
                .FirstOrDefaultAsync(m => m.DTQC114PersonID == id);
            if (dTQC114Person == null)
            {
                return NotFound();
            }

            return View(dTQC114Person);
        }

        // GET: DTQC114Person/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DTQC114Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTQC114PersonID,DTQC114Age,DTQC114Ngaysinh")] DTQC114Person dTQC114Person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dTQC114Person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dTQC114Person);
        }

        // GET: DTQC114Person/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Person = await _context.DTQC114Person.FindAsync(id);
            if (dTQC114Person == null)
            {
                return NotFound();
            }
            return View(dTQC114Person);
        }

        // POST: DTQC114Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DTQC114PersonID,DTQC114Age,DTQC114Ngaysinh")] DTQC114Person dTQC114Person)
        {
            if (id != dTQC114Person.DTQC114PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dTQC114Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTQC114PersonExists(dTQC114Person.DTQC114PersonID))
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
            return View(dTQC114Person);
        }

        // GET: DTQC114Person/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Person = await _context.DTQC114Person
                .FirstOrDefaultAsync(m => m.DTQC114PersonID == id);
            if (dTQC114Person == null)
            {
                return NotFound();
            }

            return View(dTQC114Person);
        }

        // POST: DTQC114Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dTQC114Person = await _context.DTQC114Person.FindAsync(id);
            if (dTQC114Person != null)
            {
                _context.DTQC114Person.Remove(dTQC114Person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DTQC114PersonExists(string id)
        {
            return _context.DTQC114Person.Any(e => e.DTQC114PersonID == id);
        }
    }
}

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
    public class DTQC114StudentController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public DTQC114StudentController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: DTQC114Student
        public async Task<IActionResult> Index()
        {
            return View(await _context.DTQC114Student.ToListAsync());
        }

        // GET: DTQC114Student/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Student = await _context.DTQC114Student
                .FirstOrDefaultAsync(m => m.DTQC114PersonID == id);
            if (dTQC114Student == null)
            {
                return NotFound();
            }

            return View(dTQC114Student);
        }

        // GET: DTQC114Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DTQC114Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTQC114PersonID,DTQC114Age,DTQC114Ngaysinh")] DTQC114Student dTQC114Student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dTQC114Student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dTQC114Student);
        }

        // GET: DTQC114Student/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Student = await _context.DTQC114Student.FindAsync(id);
            if (dTQC114Student == null)
            {
                return NotFound();
            }
            return View(dTQC114Student);
        }

        // POST: DTQC114Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DTQC114PersonID,DTQC114Age,DTQC114Ngaysinh")] DTQC114Student dTQC114Student)
        {
            if (id != dTQC114Student.DTQC114PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dTQC114Student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTQC114StudentExists(dTQC114Student.DTQC114PersonID))
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
            return View(dTQC114Student);
        }

        // GET: DTQC114Student/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Student = await _context.DTQC114Student
                .FirstOrDefaultAsync(m => m.DTQC114PersonID == id);
            if (dTQC114Student == null)
            {
                return NotFound();
            }

            return View(dTQC114Student);
        }

        // POST: DTQC114Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dTQC114Student = await _context.DTQC114Student.FindAsync(id);
            if (dTQC114Student != null)
            {
                _context.DTQC114Student.Remove(dTQC114Student);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DTQC114StudentExists(string id)
        {
            return _context.DTQC114Student.Any(e => e.DTQC114PersonID == id);
        }
    }
}

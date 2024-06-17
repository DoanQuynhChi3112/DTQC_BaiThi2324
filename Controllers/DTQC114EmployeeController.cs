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
    public class DTQC114EmployeeController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public DTQC114EmployeeController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: DTQC114Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.DTQC114Employee.ToListAsync());
        }

        // GET: DTQC114Employee/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Employee = await _context.DTQC114Employee
                .FirstOrDefaultAsync(m => m.DTQC114PersonID == id);
            if (dTQC114Employee == null)
            {
                return NotFound();
            }

            return View(dTQC114Employee);
        }

        // GET: DTQC114Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DTQC114Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTQC114PersonID,DTQC114Age,DTQC114Ngaysinh")] DTQC114Employee dTQC114Employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dTQC114Employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dTQC114Employee);
        }

        // GET: DTQC114Employee/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Employee = await _context.DTQC114Employee.FindAsync(id);
            if (dTQC114Employee == null)
            {
                return NotFound();
            }
            return View(dTQC114Employee);
        }

        // POST: DTQC114Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DTQC114PersonID,DTQC114Age,DTQC114Ngaysinh")] DTQC114Employee dTQC114Employee)
        {
            if (id != dTQC114Employee.DTQC114PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dTQC114Employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTQC114EmployeeExists(dTQC114Employee.DTQC114PersonID))
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
            return View(dTQC114Employee);
        }

        // GET: DTQC114Employee/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTQC114Employee = await _context.DTQC114Employee
                .FirstOrDefaultAsync(m => m.DTQC114PersonID == id);
            if (dTQC114Employee == null)
            {
                return NotFound();
            }

            return View(dTQC114Employee);
        }

        // POST: DTQC114Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dTQC114Employee = await _context.DTQC114Employee.FindAsync(id);
            if (dTQC114Employee != null)
            {
                _context.DTQC114Employee.Remove(dTQC114Employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DTQC114EmployeeExists(string id)
        {
            return _context.DTQC114Employee.Any(e => e.DTQC114PersonID == id);
        }
    }
}

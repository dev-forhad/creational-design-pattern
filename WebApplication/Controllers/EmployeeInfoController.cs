using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication;
using WebApplication.Factory.AbstractFactory;
using WebApplication.Factory.FactoryMethod;
using WebApplication.Manager;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class EmployeeInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeInfo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Employee.Include(e => e.EmployeeType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EmployeeInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.EmployeeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: EmployeeInfo/Create
        public IActionResult Create()
        {
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeType, "Id", "Type");
            return View();
        }

        // POST: EmployeeInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,JobDescriptiom,Number,HourlyPay,Bonus,EmployeeTypeId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                BaseEmployeeFactory empFactory = new Factory.FactoryMethod.EmployeeManagerFactory().CreateFactory(employee);
                empFactory.ApplySalary();

                #region Abstract Factory Method
                IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                employee.ComputerDetails = manager.GetSystemDetails();
                #endregion

                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeType, "Id", "Type", employee.EmployeeTypeId);
            return View(employee);
        }

        // GET: EmployeeInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeType, "Id", "Type", employee.EmployeeTypeId);
            return View(employee);
        }

        // POST: EmployeeInfo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,JobDescriptiom,Number,HourlyPay,Bonus,EmployeeTypeId")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
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
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeType, "Id", "Type", employee.EmployeeTypeId);
            return View(employee);
        }

        // GET: EmployeeInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.EmployeeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: EmployeeInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}

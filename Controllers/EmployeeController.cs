using EmployeeManagmentSystem.Models;
using EmployeeManagmentSystem.Services;
using Microsoft.AspNetCore.Mvc;
using static EmployeeManagmentSystem.Services.ApplicationDbContext;

namespace EmployeeManagmentSystem.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeN employee)
        {
            if (employee == null)
            {
                ModelState.AddModelError("", "Invalid employee data.");
                return View(employee);
            }

            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            Employee emp = new Employee()
            {
                Name = employee.Name,
                Position = employee.Position,
                Salary = employee.Salary

            };

            _context.Employees.Add(emp);
            _context.SaveChanges();

            return RedirectToAction("Index", "Employee");
        }


        public IActionResult Edit(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return RedirectToAction("Index", "Employee");
            }

            EmployeeN emp = new EmployeeN()
            {
                Name = employee.Name,
                Position = employee.Position,
                Salary = employee.Salary

            };

            ViewData["Id"] = employee.Id;

            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(int id, EmployeeN employeeN)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return RedirectToAction("Index", "Employee");
            }

            if (!ModelState.IsValid)
            {
                ViewData["Id"] = employee.Id;
                return View(employeeN);
            }

            employee.Name = employeeN.Name;
            employee.Position = employeeN.Position;
            employee.Salary = employeeN.Salary;

            _context.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return RedirectToAction("Index", "Employee");
            }

            return View(employee); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return RedirectToAction("Index");
            }

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}

using Horizon.Data;
using Horizon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horizon.Controllers
{
    public class DepartmentsController : Controller
    {
        AppDbContext context = new();
        public IActionResult GetIndexView()
        {
            return View("Index", context.Departments.ToList());
        }
        public IActionResult GetDetailsView(int id)
        {
            if (!context.Departments.Where((d) => d.Id == id).Any())
            {
                return NotFound();
            }
            else
            {
                return View("Details", context.Departments.Include(d=>d.Employees).First((d) => d.Id == id));
            }
        }

        public IActionResult GetCreateView(Department department)
        {
            return View("Create");
        }
        public IActionResult AddNew(Department department)
        {
            if (department.Name == department.Description)
            {
                ModelState.AddModelError(string.Empty, "The name cannot be the same as the description!");
            }
            if (DateTime.Now.Hour < 19 || DateTime.Now.Hour > 21)
            {
                ModelState.AddModelError(string.Empty, "Adding department is allowed only between 7pm and 9pm");
            }
            bool duplicateName = context.Departments.Any(d => d.Name == department.Name);
            if (!duplicateName && ModelState.IsValid)
            {
                context.Departments.Add(department);
                context.SaveChanges();
                return RedirectToAction("GetIndexView");

            }
            else
            {
                if (duplicateName)
                {
                    ModelState.AddModelError("Name", "Department is already there");
                }

                return View("Create");


            }
        }
        [HttpPost]
        public IActionResult EditCurrent(Department department)
        {
            if (context.Departments.Any(d => d.Name == department.Name && d.Id != department.Id))
            {
                ModelState.AddModelError("Name", "This Department is already there");
                return View("Edit", department);
            }
            context.Departments.Update(department);
            context.SaveChanges();
            return RedirectToAction("GetIndexView");
        }

        public IActionResult GetEditView(int id)
        {
            var department = context.Departments.FirstOrDefault(d => d.Id == id);
            return View("Edit", department);
        }


    }
}

using Horizon.Data;
using Horizon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
namespace Horizon.Controllers
{
    public class EmployeesController : Controller
    {
        AppDbContext context = new();
        //https://localhost:7001/Employees/GreetVisitor
        IWebHostEnvironment webHostEnvironment;
        public EmployeesController(IWebHostEnvironment webHostEnv)
        {
            webHostEnvironment = webHostEnv;
        }
        public string GreetVisitor()
        {
            return "Welcome to the universe!";
        }
        //https://localhost:7001/Employees/CalculateAge?name=Mohamed&birthYear=2004
        public string CalculateAge(string name, int birthYear)
        {
            int age = DateTime.Now.Year - birthYear;
            return $"Hey, {name}, you are {age} years old";
        }
        //https://localhost:7001/Employees/GetIndexView
        public IActionResult GetIndexView(string? search,string? sortType,string?sortOrder)
        {
            IQueryable<Employee> employees = context.Employees.AsQueryable();
            if (string.IsNullOrWhiteSpace(search) == false)
            {
                employees = context.Employees.Where(e => e.FullName.Contains(search) || e.Position.Contains(search));
            }

            if (string.IsNullOrWhiteSpace(sortType) == false)
            {
                if (sortType == "FullName" && sortOrder == "asc")
                {
                    employees = employees.OrderBy(e => e.FullName);
                }
                else if (sortType == "FullName" && sortOrder == "desc")
                {
                    employees = employees.OrderByDescending(e => e.FullName);
                }
                else if (sortType == "Position" && sortOrder == "asc")
                {
                    employees = employees.OrderBy(e => e.Position);
                }
                else if (sortType == "Position" && sortOrder == "desc")
                {
                    employees = employees.OrderByDescending(e => e.Position);
                }
                else if (sortType == "Salary" && sortOrder == "asc")
                {
                    employees = employees.OrderBy(e => e.Salary);
                }
                else if (sortType == "Salary" && sortOrder == "desc")
                {
                    employees = employees.OrderByDescending(e => e.Salary);
                }
            }

            ViewBag.Country = "Egypt";
            ViewBag.Discount = 0.25;
            ViewBag.CurrentSearch = search;
            return View("Index", employees.ToList());
        }

        public IActionResult Index()
        {

            return View(context.Employees.ToList());
        }
        public IActionResult GetDetailsView(int id)
        {
            Employee employee = context.Employees.Include(e=>e.Department).FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View("Details", employee);

        }
        public IActionResult GetCreateView()
        {

            ViewBag.AllDepartments = new SelectList(context.Departments, "Id", "Description");
            return View("Create");
        }

        [HttpPost]
        public IActionResult AddNew(Employee emp)
        {
            
            if (context.Employees.Any(e => e.NationalId == emp.NationalId))
            {
                ModelState.AddModelError("NationalId", "Duplicate National Id"); 
            }   
            if (ModelState.IsValid)
            {

                if(emp.ImageFile == null)
                {
                    emp.ImagePath = @"\Images\No_Image.png";
                }
                else
                {
                    Guid guid = Guid.NewGuid();
                    string imageExtension = Path.GetExtension(emp.ImageFile.FileName);
                    emp.ImagePath = @"\Images\" + guid+ imageExtension;
                    string fullPath = webHostEnvironment.WebRootPath + emp.ImagePath;
                    FileStream file = new(fullPath,FileMode.Create);
                    emp.ImageFile.CopyTo(file);
                    file.Dispose();
                }
                context.Add(emp);
                context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }
            else
            {
                ViewBag.AllDepartments = new SelectList(context.Departments, "Id", "Description");
                return View("Create", emp);
            }
        }
        [HttpGet]
        public IActionResult GetEditView(int id)
        {
            var emp = context.Employees.FirstOrDefault(e=>e.Id == id);
            if (emp == null)
            {
                return NotFound();
            }
            ViewBag.AllDepartments = new SelectList(context.Departments, "Id", "Description");
            return View("Edit",emp);
        }

        [HttpPost]
        public IActionResult EditCurrent(Employee employeeFromEditView)
        {
            if (context.Employees.Any(e => e.NationalId == employeeFromEditView.NationalId && e.Id!=employeeFromEditView.Id))
            {
                ModelState.AddModelError("NationalId", "Duplicate National Id");
            }
            if (ModelState.IsValid)
            {
                if (employeeFromEditView.ImageFile != null)
                {
                    if (employeeFromEditView.ImagePath != @"\Images\No_Image.png")
                    {

                        Guid guid = Guid.NewGuid();
                        string imageExtension = Path.GetExtension(employeeFromEditView.ImageFile.FileName);
                        employeeFromEditView.ImagePath = @"\Images\" + guid + imageExtension;
                        string fullPath = webHostEnvironment.WebRootPath + employeeFromEditView.ImagePath;
                        System.IO.File.Delete(fullPath);
                        FileStream file = new(fullPath, FileMode.Create);
                        employeeFromEditView.ImageFile.CopyTo(file);
                        file.Dispose();
                    }

                }
                context.Employees.Update(employeeFromEditView);
                context.SaveChanges();
                ViewBag.AllDepartments = new SelectList(context.Departments, "Id", "Description");
                return RedirectToAction("GetIndexView");
            }
            ViewBag.AllDepartments = new SelectList(context.Departments, "Id", "Description");
            return View("Edit",employeeFromEditView);
        }
        public IActionResult GetDeleteView(int id)
        {
            Employee employee = context.Employees.Include(e => e.Department).FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View("Delete", employee);

        }

        public IActionResult DeleteEmployee(int id)
        {
            Employee employee = context.Employees.Find(id);
            
            if (employee.ImagePath != @"\Images\No_Image.png")
            {
                string fullPath = webHostEnvironment.WebRootPath + employee.ImagePath;
                System.IO.File.Delete(fullPath);
            }
            context.Employees.Remove(employee);
            context.SaveChanges();
            return RedirectToAction("GetIndexView");

        }

    }
}

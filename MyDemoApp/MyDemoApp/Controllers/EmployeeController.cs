using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        private CompanyContext context { get; set; }

        public EmployeeController(CompanyContext cc)
        {
            context = cc;
        }

        /*
        public IActionResult Index()
        {
            return View(context.Employee.Include(e => e.Department));
        }

        */

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Index(int id,string name)
        {
            string message = $"Welcome Employee: {name} id:{id}";
            return View((object)message);
        }

        public IActionResult Create()
        {
            List<SelectListItem> dept = new List<SelectListItem>();
            dept = context.Department.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.Department = dept;
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Employee emp)
        {
             
            context.Add(emp);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        /*
         
        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> Create_POST()
        {

            var employee = new Employee();

            if (await TryUpdateModelAsync(employee, "", s => s.Name,s=>s.Designation,s=>s.DepartmentId)) {
                context.Employee.Add(employee);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");

        }

        */

        public async Task<IActionResult> Update(int id)
        {

            List<SelectListItem> dept = new List<SelectListItem>();
            dept = context.Department.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.Department = dept;

            Employee emp = await context.Employee.Where(e => e.Id==id).FirstOrDefaultAsync();
            return View(emp);
        }

       
         
        [HttpPost]

        public async Task<IActionResult> Update(Employee emp)
        {

            context.Update(emp);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        

        /*
         
        [HttpPost]
        [ActionName("Update")]
        public async Task<IActionResult> Update_PUT()
        {

            var employee = new Employee();

            if (await TryUpdateModelAsync(employee, "", s => s.Name, s => s.Designation, s => s.DepartmentId))
            {
                context.Employee.Update(employee);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }

        */

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {

            var emp = new Employee() { Id = id };
            context.Remove(emp);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}

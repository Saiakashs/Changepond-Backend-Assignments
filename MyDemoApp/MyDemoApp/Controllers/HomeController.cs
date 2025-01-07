using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private CompanyContext context;

        public HomeController(ILogger<HomeController> logger, CompanyContext cc)
        {
            _logger = logger;
            context = cc;
        }

        public string CreateInformation()
        {

            var info = new Information()
            {
                Name = "Hematite InfoTech",
                License = "27AAECH1657D1ZS",
                Revenue = 100000,
                Established = Convert.ToDateTime("2017/04/28")
            };

            context.Entry(info).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();

            return "data created successfully";

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ViewBagExample()
        {
            ViewBag.CurrentDateTime = DateTime.Now;
            ViewBag.CurrentYear = DateTime.Now.Year;
            ViewBag.CurrentUser = "Akash";

            //return View();

            return RedirectToAction("Index");
        }

        public IActionResult TempDataExample()
        {
            TempData["CurrentDateTime"] = DateTime.Now;
            TempData["CurrentYear"] = DateTime.Now.Year;
            TempData["CurrentUser"] = "Akash";

            //return View();

            return RedirectToAction("Index");
        }

        public IActionResult SessionExample()
        {
            HttpContext.Session.SetString("CurrentDateTime", DateTime.Now.ToString());
            HttpContext.Session.SetInt32("CurrentYear", DateTime.Now.Year);
            HttpContext.Session.SetString("CurrentUser", "Akash");

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}

using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Controllers
{
    public class AboutController : Controller
    {
        public String Index()
        {
            return "Hey, This is a Changepond About us Page";
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

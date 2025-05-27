using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class About_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

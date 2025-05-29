using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Thank you for contacting us!";
                ModelState.Clear();
                return View();
            }
            return View(model);
        }
    }
}
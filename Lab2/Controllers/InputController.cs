using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class InputController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(InputViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }
    }
}

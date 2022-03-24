using Microsoft.AspNetCore.Mvc;
using Lab2.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Lab2.Controllers
{
    public class LoginController : Controller
    {
        private static IDictionary<string, string> dictionary = new Dictionary<string, string>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Username", model.Username.ToString());
                HttpContext.Session.SetString("Password", model.Password.ToString());
                return View("SignIn");
            }
            return View();
        }
    }
}

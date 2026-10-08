using blah.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blah.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }



    [HttpPost]
        public async Task<IActionResult> Login(string email, string password, string? returnUrl = null)
        {
            // Simple in-memory "login" placeholder without DB
            // This accepts the hardcoded admin credentials previously used for seeding
            if (!(email == "admin@store.local" && password == "Admin123!"))
            {
                TempData["LoginMessage"] = "Credenciais inválidas.";
                ViewData["ReturnUrl"] = returnUrl;
                return View();
            }

            HttpContext.Session.SetInt32("UserId", 1);
            HttpContext.Session.SetString("UserName", "Admin");
            HttpContext.Session.SetInt32("IsAdmin", 1);

            if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string name, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                TempData["RegisterMessage"] = "As palavras-passe não coincidem.";
                return View();
            }
            // Registration without DB: just simulate login and ignore persistence
            HttpContext.Session.SetInt32("UserId", 2);
            HttpContext.Session.SetString("UserName", name);
            HttpContext.Session.SetInt32("IsAdmin", 0);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}

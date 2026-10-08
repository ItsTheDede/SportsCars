using blah.Data;
using blah.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blah.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _db;

        public AdminController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var isAdmin = HttpContext.Session.GetInt32("IsAdmin") == 1;
            if (!isAdmin)
            {
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Index", "Admin") });
            }

            var users = await _db.UserAccounts
                .OrderByDescending(u => u.IsAdmin)
                .ThenBy(u => u.Name)
                .ToListAsync();

            var cartItems = await _db.CartItems
                .OrderBy(c => c.UserAccountId)
                .ThenBy(c => c.CarName)
                .ToListAsync();

            var vm = new AdminDashboardViewModel
            {
                Users = users,
                CartItems = cartItems,
                CartTotal = cartItems.Sum(i => i.UnitPrice * i.Quantity)
            };

            return View(vm);
        }
    }
}

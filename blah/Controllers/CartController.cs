using blah.Models;
using blah.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace blah.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId is null)
            {
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Index", "Cart") });
            }
            // Retrieve cart from session instead of database
            var items = HttpContext.Session.GetObjectFromJson<List<CartItemViewModel>>("Cart")
                        ?? new List<CartItemViewModel>();

            var vm = new CartPageViewModel
            {
                Items = items,
                Total = items.Sum(i => i.UnitPrice * i.Quantity)
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Add(string id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId is null)
            {
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Details", "Cars", new { id }) });
            }

            if (!CarCatalog.Cars.TryGetValue(id, out var car))
            {
                return NotFound();
            }
            var items = HttpContext.Session.GetObjectFromJson<List<CartItemViewModel>>("Cart")
                        ?? new List<CartItemViewModel>();

            var existing = items.FirstOrDefault(c => c.CarId == id);

            if (existing is null)
            {
                items.Add(new CartItemViewModel
                {
                    Id = items.Count == 0 ? 1 : items.Max(i => i.Id) + 1,
                    CarId = id,
                    CarName = car.Name,
                    UnitPrice = car.Price,
                    Quantity = 1,
                    ImagePath = car.ImagePath,
                    Model3dPath = car.Model3dPath
                });
            }
            else
            {
                existing.Quantity += 1;
            }

            HttpContext.Session.SetObjectAsJson("Cart", items);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId is null)
            {
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Index", "Cart") });
            }
            var items = HttpContext.Session.GetObjectFromJson<List<CartItemViewModel>>("Cart")
                        ?? new List<CartItemViewModel>();

            var item = items.FirstOrDefault(c => c.Id == id);
            if (item is not null)
            {
                items.Remove(item);
                HttpContext.Session.SetObjectAsJson("Cart", items);
            }

            return RedirectToAction("Index");
        }
    }
}

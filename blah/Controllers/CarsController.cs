using blah.Models;
using Microsoft.AspNetCore.Mvc;

namespace blah.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet]
        public IActionResult Catalog()
        {
            var cars = CarCatalog.Cars.Values.ToList();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cars = CarCatalog.Cars.Values.ToList();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            if (string.IsNullOrWhiteSpace(id) || !CarCatalog.Cars.TryGetValue(id, out var car))
            {
                return NotFound();
            }

            return View(car);
        }
    }
}

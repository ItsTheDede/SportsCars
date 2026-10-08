using blah.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace blah.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string email, string nome, string assunto, string contextoProblema)
        {
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(assunto) ||
                string.IsNullOrWhiteSpace(contextoProblema))
            {
                TempData["ContactMessage"] = "Preencha todos os campos.";
                return View();
            }

            TempData["ContactMessage"] = "Pedido enviado com sucesso. Vamos responder brevemente.";
            return RedirectToAction(nameof(Contact));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

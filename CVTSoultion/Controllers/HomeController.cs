using CVTSoultion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CVTSoultion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult News_publications()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Imprint()
        {
            return View();
        }
        public IActionResult Impressum()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Terms_use()
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
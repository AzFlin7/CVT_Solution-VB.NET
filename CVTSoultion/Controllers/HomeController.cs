using CVTSoultion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CVTSoultion.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("news-publications")]
        public IActionResult NewsPublications()
        {
            return View();
        }

        [Route("news-publications2")]
        public IActionResult NewsPublications2()
        {
            return View();
        }

        [Route("news-publications3")]
        public IActionResult News_publications3()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("imprint")]
        public IActionResult Imprint()
        {
            return View();
        }

        [Route("impressum")]
        public IActionResult Impressum()
        {
            return View();
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("terms-use")]
        public IActionResult TermsUse()
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
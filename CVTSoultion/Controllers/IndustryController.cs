using Microsoft.AspNetCore.Mvc;

namespace CVTSoultion.Controllers
{
    [Route("industry")]
    public class IndustryController : Controller
    {
        [Route("process-control")]
        public IActionResult ProcessControl()
        {
            return View();
        }

        [Route("plastic-ploymers")]
        public IActionResult PlasticPloymers()
        {
            return View();
        }

        [Route("pharmaceutical-production")]
        public IActionResult PharmaceuticalProduction()
        {
            return View();
        }

        [Route("paint-coatings")]
        public IActionResult PaintCoatings()
        {
            return View();
        }

        [Route("chemical-manufacturing")]
        public IActionResult ChemicalManufacturing()
        {
            return View();
        }
    }
}

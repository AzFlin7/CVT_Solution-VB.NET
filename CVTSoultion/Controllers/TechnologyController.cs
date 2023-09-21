using Microsoft.AspNetCore.Mvc;

namespace CVTSoultion.Controllers
{
    [Route("technology")]
    public class TechnologyController : Controller
    {
        [Route("continuous-production")]
        public IActionResult ContinuousProduction()
        {
            return View();
        }
        
        [Route("process-monitoring")]
        public IActionResult ProcessMonitoring()
        {
            return View();
        }

        [Route("inline-spectroscopy")]
        public IActionResult InlineSpectroscopy()
        {
            return View();
        }

        [Route("industry-4-solutions")]
        public IActionResult Industry4Solutions()
        {
            return View();
        }
    }
}

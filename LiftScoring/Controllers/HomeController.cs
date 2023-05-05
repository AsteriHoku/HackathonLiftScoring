using LiftScoring.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiftScoring.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var lifter = new LifterModel
            {
                Name = "Lixa",
                isFemale = true,
                DeadLift = 125,
                SquatLift = 75,
                BenchLift = 50,
                CurlLift = 50,
                OverheadPressLift = 50,
                RowLift = 65
            };
            return View(lifter);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
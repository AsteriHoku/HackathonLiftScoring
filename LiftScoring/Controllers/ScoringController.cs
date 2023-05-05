using Microsoft.AspNetCore.Mvc;

namespace LiftScoring.Controllers
{
    public class ScoringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

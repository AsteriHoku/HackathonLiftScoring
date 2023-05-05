using Microsoft.AspNetCore.Mvc;

namespace LiftScoring.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

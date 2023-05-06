using Microsoft.AspNetCore.Mvc;

namespace LiftScoring.Controllers
{
    public class ScoringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<double> GetScoreByGenderAsync(double liftWeight, bool isFemale)
        {
            var score = isFemale ? (liftWeight * 1.8) : liftWeight;
            return score;
        }
    }
}
}

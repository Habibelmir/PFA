using Microsoft.AspNetCore.Mvc;

namespace Projet_pfa.Controllers
{
    public class AccueilController : Controller
    {
        [Route("/Accueil")]    
        public IActionResult accueil()
        {
            return View();
        }
    }
}

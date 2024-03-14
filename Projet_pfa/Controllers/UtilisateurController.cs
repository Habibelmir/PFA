using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Projet_pfa.ViewModel;

namespace Projet_pfa.Controllers
{
    public class UtilisateurController : Controller
    {
        //Formulaire d'authentification
        [Route("/Authentification")]
        public IActionResult FormAuthentification()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormAuthentification(FormulaireAuthentification model)
        {
            return View();
        }


        //Formulaire d'inscription
        [Route("/Inscription")]
        public IActionResult FormInscription()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormInscription(FormulaireInscription model)
        {
            return View();
        }
    }
}   

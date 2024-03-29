using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Projet_pfa.Models;
using Projet_pfa.ViewModel;

namespace Projet_pfa.Controllers
{
    public class UtilisateursController : Controller
    {
        MyContext db;
        public UtilisateursController(MyContext db)
        {
            this.db = db;
        }
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
        public IActionResult FormInscription(Utilisateur u)
        {
            if(ModelState.IsValid)
            {
                db.Utilisateurs.Add(u);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}   

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_pfa.Models;

namespace Projet_pfa.Controllers
{
    public class EquipesController : Controller
    {
        MyContext db;
        public EquipesController(MyContext db)
        {
            this.db = db;
        }
        public IActionResult AjoutEquipes()
        {
            List<Equipe> Equipes = db.Equipes.Include(e => e.Joueurs).ToList();
            return View(Equipes);
        }
    }
}

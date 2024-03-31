using Microsoft.AspNetCore.Mvc;
using Projet_pfa.ViewModel;

namespace Projet_pfa.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult MatchInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MatchInfo(MatchInformations model)
        {
            if (!ModelState.IsValid)
            {
                return View("MatchInfo");
            }
            ViewBag.nbrtickets = model.NbrTicket;
            return View("ticketInfo");
        }
        
        public IActionResult ticketInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ticketInfo(TicketInformation model)
        {
            List<string> nomcomplets = model.NomComplets;
            ViewBag.nomcompletsCount = nomcomplets.Count;
            ViewBag.nomcomplets = nomcomplets;
            return View();
        }


        public IActionResult Recapitulatif()
        {
            return View();
        }



    }
}

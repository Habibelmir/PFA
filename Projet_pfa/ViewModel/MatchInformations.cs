using System.ComponentModel.DataAnnotations;

namespace Projet_pfa.ViewModel
{
    public enum Categorie
    {
        CategorieA,
        CategorieB, 
        CategorieC
    };
   
    public class MatchInformations
    {
        //possible que cette property soit une enumeration ! 
        [Display(Name = "Catégorie de Siège")]
        [Required(ErrorMessage ="Veuillez choisir une categorie")]
        public Categorie CategorieSiege { get; set; }

        [Display(Name ="Nombre de Ticket")]
        [Required(ErrorMessage ="Veuillez choisir un nombre de tickets")]
        public int NbrTicket{ get; set;}
    }
}

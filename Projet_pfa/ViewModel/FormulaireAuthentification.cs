using System.ComponentModel.DataAnnotations;

namespace Projet_pfa.ViewModel
{
    public class FormulaireAuthentification
    {
        [Required(ErrorMessage = "Le Nom d'utlisateur est obligatoire")]
        
        public string NomUtilisateur { get; set; }

        [Required(ErrorMessage = "Le Password est obligatoire")]
        [DataType(DataType.Password)]
        public string MotDePasse { get; set; }
    }
}

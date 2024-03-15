using System.ComponentModel.DataAnnotations;

namespace Projet_pfa.Models
{
    public enum Role
    {
        user,
        moderateur,
    }
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom{ get; set; }
        [Required(ErrorMessage = "veuillez saisir votre prenom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le login est obligatoire")]
        public string Login {  get; set; }

        [Required(ErrorMessage = "Veuillez saisir votre mot de passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Role Role { get; set; }

        public IList<Ticket> Tickets { get; set; }


    }
}

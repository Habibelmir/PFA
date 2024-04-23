using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_pfa.Models
{
    [Table("Like")]
    public class Like
    {
        public int Id { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int UtilisateurId { get; set; } 
    }
}

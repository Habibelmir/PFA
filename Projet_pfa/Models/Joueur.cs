using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_pfa.Models
{
    [Table("Joueur")]
    public class Joueur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NumeroMaillot { get; set; }
        public int Age { get; set; }
        public Equipe Equipe { get; set; }
        public int EquipeId { get; set; }
    }
}

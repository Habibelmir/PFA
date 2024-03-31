using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_pfa.Models
{
    [Table("Equipe")]
    public class Equipe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Drapeau {  get; set; }
        public IList<MatchEquipe>? MatchEquipes { get; set; }
        public IList<Joueur>? Joueurs { get; set; }
    }
}

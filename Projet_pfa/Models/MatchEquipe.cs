using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_pfa.Models
{
    [Table("MatchEquipe")]
    public class MatchEquipe
    {
        public int Id { get; set; }
        public Equipe Equipe { get; set; }
        public int EquipeId { get; set; }
        public Match Match { get; set; }
        public int MatchId { get; set; }
    }
}

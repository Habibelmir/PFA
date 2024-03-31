using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_pfa.Models
{
    public class MatchEquipe
    {
        public int Id { get; set; }
        public Equipe Equipe { get; set; }
        [ForeignKey("Equipe")]
        public int EquipeId { get; set; }
        public Match Match { get; set; }

        [ForeignKey("Match")]
        public int MatchId { get; set; }
    }
}

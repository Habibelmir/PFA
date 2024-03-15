namespace Projet_pfa.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public IList<MatchEquipe> MatchEquipes { get; set; }
        public IList<Joueur> Joueurs { get; set; }
    }
}

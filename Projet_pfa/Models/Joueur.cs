namespace Projet_pfa.Models
{
    public class Joueur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NumeroMaillot { get; set; }

        public Equipe Equipe { get; set; }
        public int EquipeId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Net.Sockets;

namespace Projet_pfa.Models
{
    public enum Role
    {
        user,
        admin,
    }
    [Table("Utilisateur")]
    public class Utilisateur
    {
        public int Id {  get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public Nationalite Nationalite { get; set; }
        public int NationaliteId { get; set; }

        public IList<Publication> publications { get; set; }
        public IList<Ticket> Tickets { get; set; }
        public IList<Commentaire>Commentaires { get; set;}
        public IList<Like>Likes { get; set; }

    }
}

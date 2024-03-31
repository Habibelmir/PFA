using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Net.Sockets;

namespace Projet_pfa.Models
{
    public enum Role
    {
        user,
        moderateur,
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

        public IList<Ticket> Tickets { get; set; }

    }
}

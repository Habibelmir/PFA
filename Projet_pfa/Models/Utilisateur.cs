using System.Data;
using System.Net.Sockets;

namespace Projet_pfa.Models
{
    public class Utilisateur
    {
        public int id {  get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string login {  get; set; }
        public string password { get; set; }
        public Role Role { get; set; }

        public IList<Ticket> Tickets { get; set; }

    }
}

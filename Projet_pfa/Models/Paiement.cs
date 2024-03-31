using System.Net.Sockets;

namespace Projet_pfa.Models
{
    public class Paiement
    {
        public int Id { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}

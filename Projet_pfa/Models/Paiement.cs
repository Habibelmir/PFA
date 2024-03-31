using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace Projet_pfa.Models
{
    [Table("Paiement")]
    public class Paiement
    {
        public int Id { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}

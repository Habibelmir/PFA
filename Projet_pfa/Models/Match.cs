using System.Net.Sockets;

namespace Projet_pfa.Models
{
    public class Match
    {
        enum status
        {
            joue, 
            nonjoue,

        }
        public int Id { get; set; }
        public DateTime Datee { get; set; }
        public double PrixSiegeCat1 { get; set; }
        public double PrixSiegeCat2 { get; set; }
        public double PrixSiegeCat3 { get; set; }
        public string Resultat { get; set; }
        public int nbrsiegeReserveCat1 {  get; set; }
        public int nbrsiegeReserveCat2 { get; set; }
        public int nbrsiegeReserveCat3 { get; set; }

      
        public IList<Ticket> Tickets { get; set; }


        //public Stade stade { get; set; }
        //public int StadeId { get; set; }
    }
}

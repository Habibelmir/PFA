using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace Projet_pfa.Models
{
    [Table("Match")]
    public class Match
    {
        public enum MatchEnum
        {
            joue, 
            nonjoue,

        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double PrixSiegeCat1 { get; set; }
        public double PrixSiegeCat2 { get; set; }
        public double PrixSiegeCat3 { get; set; }
        public MatchEnum Status {  get; set; } 
        public string Resultat { get; set; }
        public int nbrsiegeReserveCat1 {  get; set; }
        public int nbrsiegeReserveCat2 { get; set; }
        public int nbrsiegeReserveCat3 { get; set; }

      
        public IList<Ticket> Tickets { get; set; }


        //public Stade stade { get; set; }
        //public int StadeId { get; set; }
    }
}

namespace Projet_pfa.Models
{
    public class Match
    { // enum status 
        public int Id { get; set; }
        public DateTime Datee { get; set; }
        public double PrixSiegeCat1 { get; set; }
        public double PrixSiegeCat2 { get; set; }
        public double PrixSiegeCat3 { get; set; }
        //nbr siege reserve

        public IList<Ticket> Tickets { get; set; }
        //public Stade stade { get; set; }
        //public int StadeId { get; set; }
    }
}


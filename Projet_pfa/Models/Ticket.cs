namespace Projet_pfa.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime DateAchat { get; set; } 
        public string NomBeneficiaire { get; set; }
        public string PrenomBeneficiaire { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}

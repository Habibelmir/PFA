using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_pfa.Models
{
    [Table("Ticket")]

    public class Ticket
    {
        public int Id { get; set; }
        public DateTime DateAchat { get; set; }
        public string NomBeneficiaire { get; set; }
        public string PrenomBeneficiaire { get; set; }
        //Gestion de concurrence :
        //Cette annotation ne peut être appliquer que sur les champs de type byte[].
        //Notez que le respect du nom (RowVersion) est obligatoire. 
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int UtilisateurId { get; set; }

        public Match Match { get; set; }
        public int MatchId { get; set; }

        public Paiement Paiement { get; set; }
        public int PaiementId { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_pfa.Models
{
    [Table("Publication")]
    public class Publication
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Photo { get; set; }
        public string Texte { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int UtilisateurtId { get; set; }
        public IList<Commentaire> Commentaires { get; set; }
        public IList<Like>Likes { get; set; }
    }
}

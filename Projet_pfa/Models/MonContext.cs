using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Projet_pfa.Models
{
    public class MonContext :DbContext
    {
        public DbSet<User> Users { get; set; }  
        public DbSet<Match>Matches { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<MatchEquipe> MatcheEquipes { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public MonContext(DbContextOptions<MonContext>opt) : base(opt) { }
    }
}

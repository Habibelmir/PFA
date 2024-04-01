using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace Projet_pfa.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<MatchEquipe> MatcheEquipes { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public MyContext(DbContextOptions<MyContext> opt) : base(opt) { }
    }
}

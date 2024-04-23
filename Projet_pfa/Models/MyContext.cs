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
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Nationalite> Nationalites { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Stade> Stades { get; set; }
        public DbSet<Groupe> Groupes { get; set; }
        public DbSet<Like> Likes { get; set; }

        public MyContext(DbContextOptions<MyContext> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(m => m.Equipe1)
                .WithMany(e => e.MatchesEquipe1)
                .HasForeignKey(m => m.Equipe1Id);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Equipe2)
                .WithMany(e => e.MatchesEquipe2)
                .HasForeignKey(m => m.Equipe2Id);
        }
    } 
}
    


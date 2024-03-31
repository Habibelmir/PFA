﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet_pfa.Models;

#nullable disable

namespace Projet_pfa.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240331021855_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Projet_pfa.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Drapeau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipe");
                });

            modelBuilder.Entity("Projet_pfa.Models.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("EquipeId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroMaillot")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipeId");

                    b.ToTable("Joueur");
                });

            modelBuilder.Entity("Projet_pfa.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("PrixSiegeCat1")
                        .HasColumnType("float");

                    b.Property<double>("PrixSiegeCat2")
                        .HasColumnType("float");

                    b.Property<double>("PrixSiegeCat3")
                        .HasColumnType("float");

                    b.Property<string>("Resultat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("nbrsiegeReserveCat1")
                        .HasColumnType("int");

                    b.Property<int>("nbrsiegeReserveCat2")
                        .HasColumnType("int");

                    b.Property<int>("nbrsiegeReserveCat3")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("Projet_pfa.Models.MatchEquipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EquipeId")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipeId");

                    b.HasIndex("MatchId");

                    b.ToTable("MatchEquipe");
                });

            modelBuilder.Entity("Projet_pfa.Models.Paiement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Paiement");
                });

            modelBuilder.Entity("Projet_pfa.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateAchat")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MatchId")
                        .HasColumnType("int");

                    b.Property<string>("NomBeneficiaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaiementId")
                        .HasColumnType("int");

                    b.Property<string>("PrenomBeneficiaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PaiementId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Projet_pfa.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Utilisateur");
                });

            modelBuilder.Entity("Projet_pfa.Models.Joueur", b =>
                {
                    b.HasOne("Projet_pfa.Models.Equipe", "Equipe")
                        .WithMany("Joueurs")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("Projet_pfa.Models.MatchEquipe", b =>
                {
                    b.HasOne("Projet_pfa.Models.Equipe", "Equipe")
                        .WithMany("MatchEquipes")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_pfa.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");

                    b.Navigation("Match");
                });

            modelBuilder.Entity("Projet_pfa.Models.Ticket", b =>
                {
                    b.HasOne("Projet_pfa.Models.Match", null)
                        .WithMany("Tickets")
                        .HasForeignKey("MatchId");

                    b.HasOne("Projet_pfa.Models.Paiement", null)
                        .WithMany("Tickets")
                        .HasForeignKey("PaiementId");

                    b.HasOne("Projet_pfa.Models.Utilisateur", "Utilisateur")
                        .WithMany("Tickets")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Projet_pfa.Models.Equipe", b =>
                {
                    b.Navigation("Joueurs");

                    b.Navigation("MatchEquipes");
                });

            modelBuilder.Entity("Projet_pfa.Models.Match", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Projet_pfa.Models.Paiement", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Projet_pfa.Models.Utilisateur", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}

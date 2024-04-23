using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_pfa.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groupe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paiement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ville", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drapeau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipe_Groupe_GroupeId",
                        column: x => x.GroupeId,
                        principalTable: "Groupe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    NationaliteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateur_Nationalite_NationaliteId",
                        column: x => x.NationaliteId,
                        principalTable: "Nationalite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Stade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nbSiegeCat1 = table.Column<int>(type: "int", nullable: false),
                    nbSiegeCat2 = table.Column<int>(type: "int", nullable: false),
                    nbSiegeCat3 = table.Column<int>(type: "int", nullable: false),
                    VilleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stade_Ville_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Ville",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Joueur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroMaillot = table.Column<int>(type: "int", nullable: false),
                    DateNaissance = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Joueur_Equipe_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Publication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Texte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    UtilisateurtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publication_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrixSiegeCat1 = table.Column<double>(type: "float", nullable: false),
                    PrixSiegeCat2 = table.Column<double>(type: "float", nullable: false),
                    PrixSiegeCat3 = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Resultat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nbrsiegeReserveCat1 = table.Column<int>(type: "int", nullable: false),
                    nbrsiegeReserveCat2 = table.Column<int>(type: "int", nullable: false),
                    nbrsiegeReserveCat3 = table.Column<int>(type: "int", nullable: false),
                    Equipe1Id = table.Column<int>(type: "int", nullable: false),
                    Equipe2Id = table.Column<int>(type: "int", nullable: false),
                    StadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Match_Equipe_Equipe1Id",
                        column: x => x.Equipe1Id,
                        principalTable: "Equipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Match_Equipe_Equipe2Id",
                        column: x => x.Equipe2Id,
                        principalTable: "Equipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Match_Stade_StadeId",
                        column: x => x.StadeId,
                        principalTable: "Stade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Commentaire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationId = table.Column<int>(type: "int", nullable: false),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commentaire_Publication_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Commentaire_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    PublicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Like_Publication_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publication",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Like_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomBeneficiaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrenomBeneficiaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    PaiementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ticket_Paiement_PaiementId",
                        column: x => x.PaiementId,
                        principalTable: "Paiement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ticket_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_PublicationId",
                table: "Commentaire",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_UtilisateurId",
                table: "Commentaire",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipe_GroupeId",
                table: "Equipe",
                column: "GroupeId");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_EquipeId",
                table: "Joueur",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_PublicationId",
                table: "Like",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_UtilisateurId",
                table: "Like",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Equipe1Id",
                table: "Match",
                column: "Equipe1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Equipe2Id",
                table: "Match",
                column: "Equipe2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_StadeId",
                table: "Match",
                column: "StadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Publication_UtilisateurId",
                table: "Publication",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Stade_VilleId",
                table: "Stade",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_MatchId",
                table: "Ticket",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PaiementId",
                table: "Ticket",
                column: "PaiementId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UtilisateurId",
                table: "Ticket",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_NationaliteId",
                table: "Utilisateur",
                column: "NationaliteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaire");

            migrationBuilder.DropTable(
                name: "Joueur");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Publication");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "Paiement");

            migrationBuilder.DropTable(
                name: "Utilisateur");

            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "Stade");

            migrationBuilder.DropTable(
                name: "Nationalite");

            migrationBuilder.DropTable(
                name: "Groupe");

            migrationBuilder.DropTable(
                name: "Ville");
        }
    }
}

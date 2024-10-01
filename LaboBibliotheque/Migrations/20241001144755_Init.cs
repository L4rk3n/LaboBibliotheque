using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboBibliotheque.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    IDadresse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Boite = table.Column<int>(type: "int", nullable: false),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.IDadresse);
                });

            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    IDauteur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.IDauteur);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    IDgenre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.IDgenre);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    IDutilisateur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDadresse = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "[Nom] + [Prenom] + CAST(YEAR([DateNaissance]) AS NVARCHAR)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.IDutilisateur);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Adresses_IDadresse",
                        column: x => x.IDadresse,
                        principalTable: "Adresses",
                        principalColumn: "IDadresse",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Livres",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDgenre = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    stocklocation = table.Column<int>(type: "int", nullable: false),
                    stockachat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livres", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Livres_Genres_IDgenre",
                        column: x => x.IDgenre,
                        principalTable: "Genres",
                        principalColumn: "IDgenre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Achats",
                columns: table => new
                {
                    IDachat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDutilisateur = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achats", x => x.IDachat);
                    table.ForeignKey(
                        name: "FK_Achats_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Achats_Utilisateurs_IDutilisateur",
                        column: x => x.IDutilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "IDutilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ecrits",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    IDauteur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecrits", x => new { x.ISBN, x.IDauteur });
                    table.ForeignKey(
                        name: "FK_Ecrits_Auteurs_IDauteur",
                        column: x => x.IDauteur,
                        principalTable: "Auteurs",
                        principalColumn: "IDauteur");
                    table.ForeignKey(
                        name: "FK_Ecrits_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN");
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    IDlocation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    IDutilisateur = table.Column<int>(type: "int", nullable: false),
                    DateLocation = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DateRetour = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "DATEADD(day, 14, GETDATE())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.IDlocation);
                    table.ForeignKey(
                        name: "FK_Locations_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_Utilisateurs_IDutilisateur",
                        column: x => x.IDutilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "IDutilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "IDadresse", "Boite", "Localite", "Numero", "Pays", "Rue", "UtilisateurId" },
                values: new object[,]
                {
                    { -10, 0, "Hasselt", 9, "Belgique", "Koning Albertstraat", -10 },
                    { -9, 4, "Bruges", 7, "Belgique", "Steenstraat", -9 },
                    { -8, 0, "Louvain", 15, "Belgique", "Bondgenotenlaan", -8 },
                    { -7, 12, "Mons", 3, "Belgique", "Grand-Place", -7 },
                    { -6, 0, "Charleroi", 12, "Belgique", "Rue de la Montagne", -6 },
                    { -5, 0, "Namur", 8, "Belgique", "Rue de Fer", -5 },
                    { -4, 0, "Liège", 10, "Belgique", "Place Saint-Lambert", -4 },
                    { -3, 3, "Gand", 5, "Belgique", "Veldstraat", -3 },
                    { -2, 1, "Anvers", 20, "Belgique", "Meir", -2 },
                    { -1, 0, "Bruxelles", 16, "Belgique", "Rue de la Loi", -1 }
                });

            migrationBuilder.InsertData(
                table: "Auteurs",
                columns: new[] { "IDauteur", "Nom", "Prenom" },
                values: new object[,]
                {
                    { -10, "Baudelaire", "Charles" },
                    { -9, "Proust", "Marcel" },
                    { -8, "Camus", "Albert" },
                    { -7, "Sartre", "Jean-Paul" },
                    { -6, "Verne", "Jules" },
                    { -5, "Balzac", "Honoré de" },
                    { -4, "Flaubert", "Gustave" },
                    { -3, "Dumas", "Alexandre" },
                    { -2, "Zola", "Émile" },
                    { -1, "Hugo", "Victor" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "IDgenre", "Nom" },
                values: new object[,]
                {
                    { -30, "Western" },
                    { -29, "True crime" },
                    { -28, "Voyage" },
                    { -27, "Science" },
                    { -26, "Religion" },
                    { -25, "Psychologie" },
                    { -24, "Philosophie" },
                    { -23, "Mémoires" },
                    { -22, "Fiction historique" },
                    { -21, "Roman graphique" },
                    { -20, "Policier" },
                    { -19, "Anthologie" },
                    { -18, "Satire" },
                    { -17, "Drame" },
                    { -16, "Poésie" },
                    { -15, "Classique" },
                    { -14, "Dystopie" },
                    { -13, "Jeunes adultes" },
                    { -12, "Enfants" },
                    { -11, "Aventure" },
                    { -10, "Développement personnel" },
                    { -9, "Historique" },
                    { -8, "Biographie" },
                    { -7, "Non-fiction" },
                    { -6, "Horreur" },
                    { -5, "Romance" },
                    { -4, "Thriller" },
                    { -3, "Mystère" },
                    { -2, "Fantaisie" },
                    { -1, "Science-fiction" }
                });

            migrationBuilder.InsertData(
                table: "Livres",
                columns: new[] { "ISBN", "IDgenre", "Prix", "Titre", "stockachat", "stocklocation" },
                values: new object[,]
                {
                    { -123465, -16, 7.9900000000000002, "Les Fleurs du mal", 6, 3 },
                    { -123464, -15, 16.989999999999998, "À la recherche du temps perdu", 11, 5 },
                    { -123463, -15, 8.9900000000000002, "L'Étranger", 9, 4 },
                    { -123462, -24, 15.99, "L'Être et le Néant", 3, 1 },
                    { -123461, -1, 9.9900000000000002, "Vingt mille lieues sous les mers", 14, 7 },
                    { -123460, -15, 13.99, "La Comédie humaine", 5, 2 },
                    { -123459, -15, 11.99, "Madame Bovary", 12, 6 },
                    { -123458, -11, 14.99, "Le Comte de Monte-Cristo", 8, 4 },
                    { -123457, -9, 10.99, "Germinal", 7, 3 },
                    { -123456, -15, 12.99, "Les Misérables", 10, 5 }
                });

            migrationBuilder.InsertData(
                table: "Utilisateurs",
                columns: new[] { "IDutilisateur", "DateNaissance", "Email", "IDadresse", "Nom", "Password", "Prenom" },
                values: new object[,]
                {
                    { -10, new DateTime(1997, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.leroy@example.com", -10, "Leroy", "LeroyEmma1997", "Emma" },
                    { -9, new DateTime(1983, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "antoine.michel@example.com", -9, "Michel", "MichelAntoine1983", "Antoine" },
                    { -8, new DateTime(1992, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura.simon@example.com", -8, "Simon", "SimonLaura1992", "Laura" },
                    { -7, new DateTime(1988, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "paul.moreau@example.com", -7, "Moreau", "MoreauPaul1988", "Paul" },
                    { -6, new DateTime(1975, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "julie.lefevre@example.com", -6, "Lefevre", "LefevreJulie1975", "Julie" },
                    { -5, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "pierre.durand@example.com", -5, "Durand", "DurandPierre2000", "Pierre" },
                    { -4, new DateTime(1995, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophie.dubois@example.com", -4, "Dubois", "DuboisSophie1995", "Sophie" },
                    { -3, new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "luc.bernard@example.com", -3, "Bernard", "BernardLuc1990", "Luc" },
                    { -2, new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie.martin@example.com", -2, "Martin", "MartinMarie1985", "Marie" },
                    { -1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jean.dupont@example.com", -1, "Dupont", "DupontJean1980", "Jean" }
                });

            migrationBuilder.InsertData(
                table: "Achats",
                columns: new[] { "IDachat", "DateAchat", "IDutilisateur", "ISBN" },
                values: new object[,]
                {
                    { -10, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5107), -10, -123465 },
                    { -9, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5105), -9, -123464 },
                    { -8, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5103), -8, -123463 },
                    { -7, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5101), -7, -123462 },
                    { -6, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5099), -6, -123461 },
                    { -5, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5096), -5, -123460 },
                    { -4, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5094), -4, -123459 },
                    { -3, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5092), -3, -123458 },
                    { -2, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5089), -2, -123457 },
                    { -1, new DateTime(2024, 10, 1, 16, 47, 54, 962, DateTimeKind.Local).AddTicks(5002), -1, -123456 }
                });

            migrationBuilder.InsertData(
                table: "Ecrits",
                columns: new[] { "IDauteur", "ISBN" },
                values: new object[,]
                {
                    { -10, -123465 },
                    { -9, -123464 },
                    { -8, -123463 },
                    { -7, -123462 },
                    { -6, -123461 },
                    { -5, -123460 },
                    { -4, -123459 },
                    { -3, -123458 },
                    { -2, -123457 },
                    { -1, -123456 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "IDlocation", "DateLocation", "DateRetour", "IDutilisateur", "ISBN" },
                values: new object[,]
                {
                    { -10, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8153), -10, -123465 },
                    { -9, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8148), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8149), -9, -123464 },
                    { -8, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8145), -8, -123463 },
                    { -7, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8140), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8141), -7, -123462 },
                    { -6, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8136), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8138), -6, -123461 },
                    { -5, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8132), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8133), -5, -123460 },
                    { -4, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8129), -4, -123459 },
                    { -3, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8125), -3, -123458 },
                    { -2, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8119), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8121), -2, -123457 },
                    { -1, new DateTime(2024, 10, 1, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8044), new DateTime(2024, 10, 15, 16, 47, 54, 969, DateTimeKind.Local).AddTicks(8113), -1, -123456 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achats_IDutilisateur",
                table: "Achats",
                column: "IDutilisateur");

            migrationBuilder.CreateIndex(
                name: "IX_Achats_ISBN",
                table: "Achats",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Ecrits_IDauteur",
                table: "Ecrits",
                column: "IDauteur");

            migrationBuilder.CreateIndex(
                name: "IX_Livres_IDgenre",
                table: "Livres",
                column: "IDgenre");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_IDutilisateur",
                table: "Locations",
                column: "IDutilisateur");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ISBN",
                table: "Locations",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_IDadresse",
                table: "Utilisateurs",
                column: "IDadresse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achats");

            migrationBuilder.DropTable(
                name: "Ecrits");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Auteurs");

            migrationBuilder.DropTable(
                name: "Livres");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}

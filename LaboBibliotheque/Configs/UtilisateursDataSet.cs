using LaboBibliotheque_BLL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_BLL.Configs
{
    internal class UtilisateursDataSet : IEntityTypeConfiguration<Utilisateurs>
    {
        public void Configure(EntityTypeBuilder<Utilisateurs> builder)
        {
            builder.HasData(
                new Utilisateurs { IDutilisateur = -1, IDadresse = -1, Nom = "Dupont", Prenom = "Jean", DateNaissance = new DateTime(1980, 1, 1), Email = "jean.dupont@example.com", Password = "DupontJean1980" },
                new Utilisateurs { IDutilisateur = -2, IDadresse = -2, Nom = "Martin", Prenom = "Marie", DateNaissance = new DateTime(1985, 2, 2), Email = "marie.martin@example.com", Password = "MartinMarie1985" },
                new Utilisateurs { IDutilisateur = -3, IDadresse = -3, Nom = "Bernard", Prenom = "Luc", DateNaissance = new DateTime(1990, 3, 3), Email = "luc.bernard@example.com", Password = "BernardLuc1990" },
                new Utilisateurs { IDutilisateur = -4, IDadresse = -4, Nom = "Dubois", Prenom = "Sophie", DateNaissance = new DateTime(1995, 4, 4), Email = "sophie.dubois@example.com", Password = "DuboisSophie1995" },
                new Utilisateurs { IDutilisateur = -5, IDadresse = -5, Nom = "Durand", Prenom = "Pierre", DateNaissance = new DateTime(2000, 5, 5), Email = "pierre.durand@example.com", Password = "DurandPierre2000" },
                new Utilisateurs { IDutilisateur = -6, IDadresse = -6, Nom = "Lefevre", Prenom = "Julie", DateNaissance = new DateTime(1975, 6, 6), Email = "julie.lefevre@example.com", Password = "LefevreJulie1975" },
                new Utilisateurs { IDutilisateur = -7, IDadresse = -7, Nom = "Moreau", Prenom = "Paul", DateNaissance = new DateTime(1988, 7, 7), Email = "paul.moreau@example.com", Password = "MoreauPaul1988" },
                new Utilisateurs { IDutilisateur = -8, IDadresse = -8, Nom = "Simon", Prenom = "Laura", DateNaissance = new DateTime(1992, 8, 8), Email = "laura.simon@example.com", Password = "SimonLaura1992" },
                new Utilisateurs { IDutilisateur = -9, IDadresse = -9, Nom = "Michel", Prenom = "Antoine", DateNaissance = new DateTime(1983, 9, 9), Email = "antoine.michel@example.com", Password = "MichelAntoine1983" },
                new Utilisateurs { IDutilisateur = -10, IDadresse = -10, Nom = "Leroy", Prenom = "Emma", DateNaissance = new DateTime(1997, 10, 10), Email = "emma.leroy@example.com", Password = "LeroyEmma1997" }
            );
        }
    }
}


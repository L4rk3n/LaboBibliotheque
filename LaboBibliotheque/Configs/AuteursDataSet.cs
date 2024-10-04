using LaboBibliotheque_DB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_DB.Configs
{
    internal class AuteursDataSet : IEntityTypeConfiguration<Auteurs>
    {
        public void Configure(EntityTypeBuilder<Auteurs> builder)
        {
            builder.HasData(
                new Auteurs { IDauteur = -1, Nom = "Hugo", Prenom = "Victor" },
                new Auteurs { IDauteur = -2, Nom = "Zola", Prenom = "Émile" },
                new Auteurs { IDauteur = -3, Nom = "Dumas", Prenom = "Alexandre" },
                new Auteurs { IDauteur = -4, Nom = "Flaubert", Prenom = "Gustave" },
                new Auteurs { IDauteur = -5, Nom = "Balzac", Prenom = "Honoré de" },
                new Auteurs { IDauteur = -6, Nom = "Verne", Prenom = "Jules" },
                new Auteurs { IDauteur = -7, Nom = "Sartre", Prenom = "Jean-Paul" },
                new Auteurs { IDauteur = -8, Nom = "Camus", Prenom = "Albert" },
                new Auteurs { IDauteur = -9, Nom = "Proust", Prenom = "Marcel" },
                new Auteurs { IDauteur = -10, Nom = "Baudelaire", Prenom = "Charles" }
            );
        }
    }
}

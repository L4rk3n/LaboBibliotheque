using LaboBibliotheque_BLL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_BLL.Configs
{
    internal class GenresDataSet : IEntityTypeConfiguration<Genres>
    {
        public void Configure(EntityTypeBuilder<Genres> builder)
        {
            builder.HasData(
                new Genres { IDgenre = -1, Nom = "Science-fiction" },
                new Genres { IDgenre = -2, Nom = "Fantaisie" },
                new Genres { IDgenre = -3, Nom = "Mystère" },
                new Genres { IDgenre = -4, Nom = "Thriller" },
                new Genres { IDgenre = -5, Nom = "Romance" },
                new Genres { IDgenre = -6, Nom = "Horreur" },
                new Genres { IDgenre = -7, Nom = "Non-fiction" },
                new Genres { IDgenre = -8, Nom = "Biographie" },
                new Genres { IDgenre = -9, Nom = "Historique" },
                new Genres { IDgenre = -10, Nom = "Développement personnel" },
                new Genres { IDgenre = -11, Nom = "Aventure" },
                new Genres { IDgenre = -12, Nom = "Enfants" },
                new Genres { IDgenre = -13, Nom = "Jeunes adultes" },
                new Genres { IDgenre = -14, Nom = "Dystopie" },
                new Genres { IDgenre = -15, Nom = "Classique" },
                new Genres { IDgenre = -16, Nom = "Poésie" },
                new Genres { IDgenre = -17, Nom = "Drame" },
                new Genres { IDgenre = -18, Nom = "Satire" },
                new Genres { IDgenre = -19, Nom = "Anthologie" },
                new Genres { IDgenre = -20, Nom = "Policier" },
                new Genres { IDgenre = -21, Nom = "Roman graphique" },
                new Genres { IDgenre = -22, Nom = "Fiction historique" },
                new Genres { IDgenre = -23, Nom = "Mémoires" },
                new Genres { IDgenre = -24, Nom = "Philosophie" },
                new Genres { IDgenre = -25, Nom = "Psychologie" },
                new Genres { IDgenre = -26, Nom = "Religion" },
                new Genres { IDgenre = -27, Nom = "Science" },
                new Genres { IDgenre = -28, Nom = "Voyage" },
                new Genres { IDgenre = -29, Nom = "True crime" },
                new Genres { IDgenre = -30, Nom = "Western" }
            );
        }
    }
}

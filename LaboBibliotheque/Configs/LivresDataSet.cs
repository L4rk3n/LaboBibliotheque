using LaboBibliotheque.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Configs
{
    internal class LivresDataSet : IEntityTypeConfiguration<Livres>
    {
        public void Configure(EntityTypeBuilder<Livres> builder)
        {
            builder.HasData(
                new Livres { ISBN = -123456, Titre = "Les Misérables", IDgenre = -15, Prix = 12.99, stocklocation = 5, stockachat = 10 },
                new Livres { ISBN = -123457, Titre = "Germinal", IDgenre = -9, Prix = 10.99, stocklocation = 3, stockachat = 7 },
                new Livres { ISBN = -123458, Titre = "Le Comte de Monte-Cristo", IDgenre = -11, Prix = 14.99, stocklocation = 4, stockachat = 8 },
                new Livres { ISBN = -123459, Titre = "Madame Bovary", IDgenre = -15, Prix = 11.99, stocklocation = 6, stockachat = 12 },
                new Livres { ISBN = -123460, Titre = "La Comédie humaine", IDgenre = -15, Prix = 13.99, stocklocation = 2, stockachat = 5 },
                new Livres { ISBN = -123461, Titre = "Vingt mille lieues sous les mers", IDgenre = -1, Prix = 9.99, stocklocation = 7, stockachat = 14 },
                new Livres { ISBN = -123462, Titre = "L'Être et le Néant", IDgenre = -24, Prix = 15.99, stocklocation = 1, stockachat = 3 },
                new Livres { ISBN = -123463, Titre = "L'Étranger", IDgenre = -15, Prix = 8.99, stocklocation = 4, stockachat = 9 },
                new Livres { ISBN = -123464, Titre = "À la recherche du temps perdu", IDgenre = -15, Prix = 16.99, stocklocation = 5, stockachat = 11 },
                new Livres { ISBN = -123465, Titre = "Les Fleurs du mal", IDgenre = -16, Prix = 7.99, stocklocation = 3, stockachat = 6 }
            );
        }
    }
}

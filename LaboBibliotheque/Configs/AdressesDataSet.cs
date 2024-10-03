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

    internal class AdressesDataSet : IEntityTypeConfiguration<Adresses>
    {
        public void Configure(EntityTypeBuilder<Adresses> builder)
        {
            builder.HasData(
                new Adresses { IDadresse = -1, UtilisateurId = -1, Pays = "Belgique", Localite = "Bruxelles", Rue = "Rue de la Loi", Numero = 16 },
                new Adresses { IDadresse = -2, UtilisateurId = -2, Pays = "Belgique", Localite = "Anvers", Rue = "Meir", Numero = 20, Boite = 1 },
                new Adresses { IDadresse = -3, UtilisateurId = -3, Pays = "Belgique", Localite = "Gand", Rue = "Veldstraat", Numero = 5, Boite = 3 },
                new Adresses { IDadresse = -4, UtilisateurId = -4, Pays = "Belgique", Localite = "Liège", Rue = "Place Saint-Lambert", Numero = 10 },
                new Adresses { IDadresse = -5, UtilisateurId = -5, Pays = "Belgique", Localite = "Namur", Rue = "Rue de Fer", Numero = 8 },
                new Adresses { IDadresse = -6, UtilisateurId = -6, Pays = "Belgique", Localite = "Charleroi", Rue = "Rue de la Montagne", Numero = 12, },
                new Adresses { IDadresse = -7, UtilisateurId = -7, Pays = "Belgique", Localite = "Mons", Rue = "Grand-Place", Numero = 3, Boite = 12 },
                new Adresses { IDadresse = -8, UtilisateurId = -8, Pays = "Belgique", Localite = "Louvain", Rue = "Bondgenotenlaan", Numero = 15 },
                new Adresses { IDadresse = -9, UtilisateurId = -9, Pays = "Belgique", Localite = "Bruges", Rue = "Steenstraat", Numero = 7, Boite = 4 },
                new Adresses { IDadresse = -10, UtilisateurId = -10, Pays = "Belgique", Localite = "Hasselt", Rue = "Koning Albertstraat", Numero = 9 }
            );
        }
    }
}

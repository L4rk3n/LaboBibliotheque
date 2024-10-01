using LaboBibliotheque.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Configs
{
    internal class LocationsDataSet : IEntityTypeConfiguration<Locations>
    {
        public void Configure(EntityTypeBuilder<Locations> builder)
        {
            builder.HasData(
                new Locations { IDlocation = -1, IDutilisateur = -1, ISBN = -123456, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -2, IDutilisateur = -2, ISBN = -123457, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -3, IDutilisateur = -3, ISBN = -123458, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -4, IDutilisateur = -4, ISBN = -123459, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -5, IDutilisateur = -5, ISBN = -123460, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -6, IDutilisateur = -6, ISBN = -123461, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -7, IDutilisateur = -7, ISBN = -123462, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -8, IDutilisateur = -8, ISBN = -123463, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -9, IDutilisateur = -9, ISBN = -123464, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) },
                new Locations { IDlocation = -10, IDutilisateur = -10, ISBN = -123465, DateLocation = DateTime.Now, DateRetour = DateTime.Now.AddDays(14) }
            );
        }
    }
}

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
    internal class LocationsConfig : IEntityTypeConfiguration<Locations>
    {
        public void Configure(EntityTypeBuilder<Locations> builder)
        {
            builder.HasKey(e => e.IDlocation);
            builder
                .Property(e => e.IDlocation)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .HasOne(a => a.Utilisateur)
                .WithMany(u => u.ListeLocations)
                .HasForeignKey(Fu => Fu.IDutilisateur);

            builder
                .HasOne(a => a.Livre)
                .WithMany(l => l.ListeLocations)
                .HasForeignKey(Fu => Fu.ISBN);

            builder
                .Property(e => e.DateLocation)
                .IsRequired();
            builder
                .Property(e => e.DateRetour)
                .IsRequired();

        }
    }
}
﻿using LaboBibliotheque_DB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_DB.Configs
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
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
            builder
                .Property(e => e.DateRetour)
                .HasDefaultValueSql("DATEADD(day, 14, GETDATE())")
                .IsRequired();

        }
    }
}
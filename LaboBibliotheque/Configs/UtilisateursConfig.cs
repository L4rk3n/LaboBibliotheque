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
    internal class UtilisateursConfig : IEntityTypeConfiguration<Utilisateurs>
    {
        public void Configure(EntityTypeBuilder<Utilisateurs> builder)
        {
            builder.HasKey(e => e.IDutilisateur);
            builder
                .Property(e => e.IDutilisateur)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .IsUnique();

            builder
                .Property(e => e.IDadresse)
                .IsRequired();
            builder
                .Property(e => e.Nom)
                .IsRequired();
            builder
                .Property(e => e.Prenom)
                .IsRequired();

            builder
                .HasIndex(e => e.DateNaissance)
                .IsRequired();
            builder
                .HasIndex(e => e.Password)
                .IsRequired();

        }
    }
}

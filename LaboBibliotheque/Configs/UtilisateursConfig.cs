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
    internal class UtilisateursConfig : IEntityTypeConfiguration<Utilisateurs>
    {
        public void Configure(EntityTypeBuilder<Utilisateurs> builder)
        {
            builder.HasKey(e => e.IDutilisateur);
            builder
                .Property(e => e.IDutilisateur)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .Property(e => e.Nom)
                .IsRequired();
            builder
                .Property(e => e.Prenom)
                .IsRequired();

            builder
                .Property(e => e.DateNaissance)
                .IsRequired();
            builder
                .Property(e => e.Email)
                .IsRequired();
            builder
                .Property(e => e.Password)
                .HasDefaultValue("[Nom] + [Prenom] + CAST(YEAR([DateNaissance]) AS NVARCHAR)")
                .IsRequired();

            builder
                .HasOne(u => u.Adresse)
                .WithMany(a => a.ListUtilisateur)
                .HasForeignKey(u => u.IDadresse);
        }
    }
}


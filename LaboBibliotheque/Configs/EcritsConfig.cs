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
    internal class EcritsConfig : IEntityTypeConfiguration<Ecrits>
    {
        public void Configure(EntityTypeBuilder<Ecrits> builder)
        {

            builder
                .HasOne(a => a.Auteur)
                .WithMany(u => u.ListeEcrits)
                .HasForeignKey(Fu => Fu.IDauteur);

            builder
                .HasOne(a => a.Livre)
                .WithMany(l => l.ListeEcrits)
                .HasForeignKey(Fu => Fu.ISBN);

        }
    }
}

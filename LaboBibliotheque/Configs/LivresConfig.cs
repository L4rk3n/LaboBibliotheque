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
    internal class LivresConfig : IEntityTypeConfiguration<Livres>
    {
        public void Configure(EntityTypeBuilder<Livres> builder)
        {
            builder.HasKey(e => e.ISBN);
            builder
                .Property(e => e.ISBN)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(e => e.Titre)
                .IsRequired();
            builder
                .HasIndex(e => e.IDauteur);
            builder
                .HasIndex(e => e.IDgenre);

            builder
                .Property(e => e.Prix)
                .IsRequired();
            
        }
    }
}

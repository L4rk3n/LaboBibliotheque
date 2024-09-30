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
    internal class BibliothequesConfig : IEntityTypeConfiguration<Bibliotheques>
    {
        public void Configure(EntityTypeBuilder<Bibliotheques> builder)
        {
            builder.HasKey(e => e.IDbibliotheque);
            builder
                .Property(e => e.IDbibliotheque)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .HasIndex(e => e.IDadresse);
            builder
                .Property(e => e.Nom)
                .IsRequired();

        }
    }
}

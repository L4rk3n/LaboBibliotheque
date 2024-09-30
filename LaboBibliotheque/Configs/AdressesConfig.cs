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
    internal class AdressesConfig : IEntityTypeConfiguration<Adresses>
    {
        public void Configure(EntityTypeBuilder<Adresses> builder)
        {
            builder.HasKey(e => e.IDadresse);
            builder
                .Property(e => e.IDadresse)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(e => e.Pays)
                .IsRequired();
            builder
                .Property(e => e.Localite)
                .IsRequired();
            builder
                .Property(e => e.Rue)
                .IsRequired();

            builder
                .Property(e => e.Numero)
                .IsRequired();
            builder
                .Property(e => e.Boite)
                .IsRequired();


        }
    }
}

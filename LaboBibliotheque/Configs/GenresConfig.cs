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
    internal class GenresConfig : IEntityTypeConfiguration<Genres>
    {
        public void Configure(EntityTypeBuilder<Genres> builder)
        {
            builder.HasKey(e => e.IDgenre);
            builder
                .Property(e => e.IDgenre)
                .ValueGeneratedOnAdd()
                .IsRequired(); 
            builder
                .Property(e => e.Nom)
                .IsRequired();
            
        }
    }
}

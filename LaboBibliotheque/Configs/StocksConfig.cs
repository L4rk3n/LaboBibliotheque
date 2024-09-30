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
    internal class StocksConfig : IEntityTypeConfiguration<Stocks>
    {
        public void Configure(EntityTypeBuilder<Stocks> builder)
        {
            builder.HasKey(e => e.IDstock);
            builder
                .Property(e => e.IDstock)
                .ValueGeneratedOnAdd()
                .IsRequired();


            builder
                .HasIndex(e => e.ISBN);

            builder
                .HasIndex(e => e.IDbibliotheque);

            builder
                .Property(e => e.stocklocation)
                .IsRequired();

            builder
                .Property(e => e.stockachat)
                .IsRequired();


        }
    }
}

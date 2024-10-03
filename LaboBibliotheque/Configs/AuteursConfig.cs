using LaboBibliotheque_BLL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_BLL.Configs
{
    internal class AuteursConfig : IEntityTypeConfiguration<Auteurs>
    {
        public void Configure(EntityTypeBuilder<Auteurs> builder)
        {
            builder.HasKey(e => e.IDauteur);
            builder
                .Property(e => e.IDauteur)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(e => e.Nom)
                .IsRequired();
            builder
                .Property(e => e.Prenom)
                .IsRequired();
        }
        
    }
}

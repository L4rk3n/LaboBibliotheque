using LaboBibliotheque_DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_Db.Configs
{
    internal class AchatsConfig : IEntityTypeConfiguration<Achats>
    {
        public void Configure(EntityTypeBuilder<Achats> builder)
        {
            builder.HasKey(e => e.IDachat);
            builder
                .Property(e => e.IDachat)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .HasOne(a => a.Utilisateur)
                .WithMany(u => u.ListeAchats)
                .HasForeignKey(Fu => Fu.IDutilisateur);

            builder
                .HasOne(a=>a.Livre)
                .WithMany(l => l.ListeAchats)
                .HasForeignKey(Fu => Fu.ISBN);

            builder
                .Property(e => e.DateAchat)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

        }
    }
}

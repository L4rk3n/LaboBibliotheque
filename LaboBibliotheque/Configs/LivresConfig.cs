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
                .Property(e => e.IDgenre);
            builder
                .Property(e => e.Prix)
                .IsRequired();
            builder
                .HasOne(l => l.Genre)
                .WithMany(g => g.ListeLivres)
                .HasForeignKey(l => l.IDgenre);
            builder
                .HasMany(l => l.ListeAuteurs)
                .WithMany(a => a.ListeLivres)
                .UsingEntity<Ecrits>(
                    L => L.HasOne<Auteurs>().WithMany().HasForeignKey(e => e.IDauteur).HasPrincipalKey(a => a.IDauteur).OnDelete(DeleteBehavior.NoAction),
                    R => R.HasOne<Livres>().WithMany().HasForeignKey(e => e.ISBN).HasPrincipalKey(l => l.ISBN).OnDelete(DeleteBehavior.NoAction),
                    p => {
                        p.ToTable("Ecrits");
                        p.HasKey(e => new {e.ISBN,e.IDauteur});
                        p.HasData(
                            new Ecrits { ISBN = -123456, IDauteur = -1 },
                            new Ecrits { ISBN = -123457, IDauteur = -2 },
                            new Ecrits { ISBN = -123458, IDauteur = -3 },
                            new Ecrits { ISBN = -123459, IDauteur = -4 },
                            new Ecrits { ISBN = -123460, IDauteur = -5 },
                            new Ecrits { ISBN = -123461, IDauteur = -6 },
                            new Ecrits { ISBN = -123462, IDauteur = -7 },
                            new Ecrits { ISBN = -123463, IDauteur = -8 },
                            new Ecrits { ISBN = -123464, IDauteur = -9 },
                            new Ecrits { ISBN = -123465, IDauteur = -10 });

                    });
            builder
                .Property(e => e.stocklocation)
                .IsRequired();

            builder
                .Property(e => e.stockachat)
                .IsRequired();

        }
    }
}

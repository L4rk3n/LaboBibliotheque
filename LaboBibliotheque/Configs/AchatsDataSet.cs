using LaboBibliotheque_BLL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_BLL.Configs
{
    internal class AchatsDataSet : IEntityTypeConfiguration<Achats>
    {
        public void Configure(EntityTypeBuilder<Achats> builder)
        {
            builder.HasData(
                new Achats { IDachat = -1, IDutilisateur = -1, ISBN = -123456, DateAchat = DateTime.Now },
                new Achats { IDachat = -2, IDutilisateur = -2, ISBN = -123457, DateAchat = DateTime.Now },
                new Achats { IDachat = -3, IDutilisateur = -3, ISBN = -123458, DateAchat = DateTime.Now },
                new Achats { IDachat = -4, IDutilisateur = -4, ISBN = -123459, DateAchat = DateTime.Now },
                new Achats { IDachat = -5, IDutilisateur = -5, ISBN = -123460, DateAchat = DateTime.Now },
                new Achats { IDachat = -6, IDutilisateur = -6, ISBN = -123461, DateAchat = DateTime.Now },
                new Achats { IDachat = -7, IDutilisateur = -7, ISBN = -123462, DateAchat = DateTime.Now },
                new Achats { IDachat = -8, IDutilisateur = -8, ISBN = -123463, DateAchat = DateTime.Now },
                new Achats { IDachat = -9, IDutilisateur = -9, ISBN = -123464, DateAchat = DateTime.Now },
                new Achats { IDachat = -10, IDutilisateur = -10, ISBN = -123465, DateAchat = DateTime.Now }
            );
        }
    }
}

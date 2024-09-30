using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Entities
{
    public class Achats
    {
        public int IDachat { get; set; }
        public int IDutilisateur { get; set; }
        public Utilisateurs Utilisateur { get; set; }
        public int ISBN { get; set; }
        public Livres Livre { get; set; }
        public DateTime DateAchat { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_DB.Entities
{
    public class Locations
    {
        public int ISBN { get; set; }
        public Livres Livre { get; set; }
        public int IDlocation { get; set; }
        public int IDutilisateur { get; set; }
        public Utilisateurs Utilisateur { get; set; }
        public DateTime DateLocation { get; set; }
        public DateTime DateRetour { get; set; }
    }
}

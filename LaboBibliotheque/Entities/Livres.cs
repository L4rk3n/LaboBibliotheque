using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Entities
{
    public class Livres
    {
        public int ISBN { get; set; }
        public string Titre { get; set; }
        public int IDgenre { get; set; }
        public double Prix { get; set; }
        public int stocklocation { get; set; }
        public int stockachat { get; set; }

        public List<Achats> ListeAchats { get; set; }
        public List<Locations> ListeLocations { get; set; }
        public List<Auteurs> ListeAuteurs { get; set; }

        public Genres Genre { get; set; }
    
    }
}

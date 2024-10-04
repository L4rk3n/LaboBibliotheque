using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_BLL.Entities
{
    public class Livres : ILivres
    {
        public int ISBN { get; internal set; }
        public string Titre { get; set; }
        public int IDgenre { get; set; }
        public double Prix { get; set; }
        public int StockLocation { get; set; }
        public int StockAchat { get; set; }

        public List<Achats> ListeAchats { get; set; }
        public List<Locations> ListeLocations { get; set; }
        public List<Auteurs> ListeAuteurs { get; set; }

        public Genres Genre { get; set; }

    }
}

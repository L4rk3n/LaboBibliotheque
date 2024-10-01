using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Entities
{
    public class Auteurs
    {
        public int IDauteur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public List<Livres> ListeLivres { get; set; }
        

    }
}

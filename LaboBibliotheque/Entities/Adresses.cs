using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Entities
{
    public class Adresses

    {
        public int IDadresse { get; set; }
        public string Pays { get; set; }
        public string Localite { get; set; }
        public string Rue { get; set; }
        public int Numero { get; set; }
        public int Boite { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Entities
{
    public class Ecrits
    {
        public int ISBN { get; set; }
        public Livres Livre { get; set; }
        public Auteurs Auteur { get; set; }
        public int IDauteur { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_DB.Entities
{
    public class Adresses

    {
        public int IDadresse { get; set; }
        public string Pays { get; set; }
        public string Localite { get; set; }
        public string Rue { get; set; }
        public int Numero { get; set; }
        public int Boite { get; set; }
        public int UtilisateurId { get; set; }

        public List<Utilisateurs> ListUtilisateur {  get; set; }   
    }
}

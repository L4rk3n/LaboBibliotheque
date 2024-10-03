using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Auteurs : IAuteurs
    {
        public int IDauteur { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public List<Livres> ListeLivres { get; set; }

    }
}

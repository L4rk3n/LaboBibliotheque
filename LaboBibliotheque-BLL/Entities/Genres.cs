using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Genres : IGenres
    {
        public int IDgenre { get; }
        public string Nom { get; }

        public List <Livres> ListeLivres { get; set; }
    }
}

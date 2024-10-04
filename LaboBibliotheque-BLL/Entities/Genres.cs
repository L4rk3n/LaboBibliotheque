using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Genres : IGenres
    {
        public int IDgenre { get; internal set; }
        public string Nom { get; internal set; }

        public List <Livres> ListeLivres { get; set; }
    }
}

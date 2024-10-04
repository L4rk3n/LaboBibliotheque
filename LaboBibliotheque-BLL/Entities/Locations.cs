using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Locations : ILocations
    {
        public int IDlocation { get; internal set; }
        public int ISBN { get; set; }
        public int IDutilisateur { get; set; }
        public DateTime DateLocation { get; set; }
        public DateTime DateRetour { get; set; }

        public Utilisateurs Utilisateur { get; set; }
        public Livres Livre { get; set; }
    }
}

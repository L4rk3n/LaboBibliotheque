using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Adresses : IAdresses

    {
        public int IDadresse { get; }
        public string Pays { get; set; }
        public string Localite { get; set; }
        public string Rue { get; set; }
        public int Numero { get; set; }
        public int Boite { get; set; }
        public int UtilisateurId { get; set; }

        public List<Utilisateurs> ListUtilisateur { get; set; }
    }
}

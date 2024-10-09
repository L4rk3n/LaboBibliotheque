using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Utilisateurs : IUtilisateurs
    {
        public int IDutilisateur { get; internal set; }
        public int IDadresse { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}

﻿using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Utilisateurs : IUtilisateurs
    {
        public int IDutilisateur { get; }
        public int IDadresse { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Adresses Adresse { get; set; }
        public List<Achats> ListeAchats { get; set; }
        public List<Locations> ListeLocations { get; set; }

    }
}
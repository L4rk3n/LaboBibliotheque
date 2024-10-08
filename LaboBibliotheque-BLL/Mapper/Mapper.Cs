﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF = LaboBibliotheque_DB.Entities;
using BLL = LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Mapper
{
    public static class Mapper
    {
        public static EF.Livres ToEF(this BLL.Livres entity)
        {
            return new EF.Livres
            {
                ISBN = entity.ISBN,
                Titre = entity.Titre,
                IDgenre = entity.IDgenre,
                Prix = entity.Prix,
                StockLocation = entity.StockLocation,
                StockAchat = entity.StockAchat,

                
            };
        }

        public static BLL.Livres ToBLL(this EF.Livres entity)
        {
            return new BLL.Livres
            {
                ISBN = entity.ISBN,
                Titre = entity.Titre,
                IDgenre = entity.IDgenre,
                Prix = entity.Prix,
                StockLocation = entity.StockLocation,
                StockAchat = entity.StockAchat,
  
            };
        }
        public static EF.Achats ToEF(this BLL.Achats entity)
        {
            return new EF.Achats
            {
                IDachat = entity.IDachat,
                IDutilisateur = entity.IDutilisateur,
                ISBN = entity.ISBN,
                DateAchat = entity.DateAchat,
            };
        }

        public static BLL.Achats ToBLL(this EF.Achats entity)
        {
            return new BLL.Achats
            {
                IDachat = entity.IDachat,
                IDutilisateur = entity.IDutilisateur,
                ISBN = entity.ISBN,
                DateAchat = entity.DateAchat,
            };
        }

        public static EF.Adresses ToEF(this BLL.Adresses entity)
        {
            return new EF.Adresses
            {
                IDadresse = entity.IDadresse,
                Pays = entity.Pays,
                Localite = entity.Localite,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Boite = entity.Boite,
                UtilisateurId = entity.UtilisateurId,

            };
        }

        public static BLL.Adresses ToBLL(this EF.Adresses entity)
        {
            return new BLL.Adresses
            {
                IDadresse = entity.IDadresse,
                Pays = entity.Pays,
                Localite = entity.Localite,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Boite = entity.Boite,
                UtilisateurId = entity.UtilisateurId,

            };
        }
        public static EF.Auteurs ToEF(this BLL.Auteurs entity)
        {
            return new EF.Auteurs
            {
                IDauteur = entity.IDauteur,
                Nom = entity.Nom,
                Prenom = entity.Prenom,

            };
        }

        public static BLL.Auteurs ToBLL(this EF.Auteurs entity)
        {
            return new BLL.Auteurs
            {
                IDauteur = entity.IDauteur,
                Nom = entity.Nom,
                Prenom = entity.Prenom,

            };
        }

        public static EF.Ecrits ToEF(this BLL.Ecrits entity)
        {
            return new EF.Ecrits
            {
                IDauteur = entity.IDauteur,
                ISBN = entity.ISBN,
            };
        }

        public static BLL.Ecrits ToBLL(this EF.Ecrits entity)
        {
            return new BLL.Ecrits
            {
                IDauteur = entity.IDauteur,
                ISBN = entity.ISBN,
            };
        }
        public static EF.Genres ToEF(this BLL.Genres entity)
        {
            return new EF.Genres
            {
                IDgenre = entity.IDgenre,
                Nom = entity.Nom,
            };
        }

        public static BLL.Genres ToBLL(this EF.Genres entity)
        {
            return new BLL.Genres
            {
                IDgenre = entity.IDgenre,
                Nom = entity.Nom,
            };
        }

        public static EF.Locations ToEF(this BLL.Locations entity)
        {
            return new EF.Locations
            {
                IDlocation = entity.IDlocation,
                ISBN = entity.ISBN,
                IDutilisateur = entity.IDutilisateur,
                DateLocation = entity.DateLocation,
                DateRetour = entity.DateRetour,
            };
        }

        public static BLL.Locations ToBLL(this EF.Locations entity)
        {
            return new BLL.Locations
            {
                IDlocation = entity.IDlocation,
                ISBN = entity.ISBN,
                IDutilisateur = entity.IDutilisateur,
                DateLocation = entity.DateLocation,
                DateRetour = entity.DateRetour,
            };
        }
        public static EF.Utilisateurs ToEF(this BLL.Utilisateurs entity)
        {
            return new EF.Utilisateurs
            {
                IDutilisateur =entity.IDutilisateur,
                IDadresse = entity.IDadresse,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                DateNaissance = entity.DateNaissance,
                Email = entity.Email,
                Password = entity.Password,

            };
        }

        public static BLL.Utilisateurs ToBLL(this EF.Utilisateurs entity)
        {
            return new BLL.Utilisateurs
            {
                IDutilisateur = entity.IDutilisateur,
                IDadresse = entity.IDadresse,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                DateNaissance = entity.DateNaissance,
                Email = entity.Email,
                Password = entity.Password,
            };
        }
    }
}

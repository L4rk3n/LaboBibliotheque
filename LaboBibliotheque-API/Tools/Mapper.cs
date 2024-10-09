using Microsoft.EntityFrameworkCore;
using DTO = LaboBibliotheque_API.DTO.Forms;
using BLL = LaboBibliotheque_BLL.Entities;

namespace LaboBibliotheque_API.Tools
{
    public static class Mapper
    { 
        public static BLL.Livres ToBLL(this DTO.Forms.LivresFormDTO entity)
        {
            return new BLL.Livres
            {
                
                Titre = entity.Titre,
                IDgenre = entity.IDgenre,
                Prix = entity.Prix,
                StockLocation = entity.StockLocation,
                StockAchat = entity.StockAchat,


            };
        }

        public static DTO.Forms.LivresFormDTO ToAPI(this BLL.Livres entity)
        {
            return new DTO.Forms.LivresFormDTO
            {
                ISBN = entity.ISBN,
                Titre = entity.Titre,
                IDgenre = entity.IDgenre,
                Prix = entity.Prix,
                StockLocation = entity.StockLocation,
                StockAchat = entity.StockAchat,

            };
        }
        public static DTO.Forms.AchatsFormDTO ToAPI(this BLL.Achats entity)
        {
            return new DTO.Forms.AchatsFormDTO
            {
                IDachat = entity.IDachat,
                IDutilisateur = entity.IDutilisateur,
                ISBN = entity.ISBN,
                DateAchat = entity.DateAchat,
            };
        }

        public static BLL.Achats ToBLL(this DTO.Forms.AchatsFormDTO entity)
        {
            return new BLL.Achats
            {
                
                IDutilisateur = entity.IDutilisateur,
                ISBN = entity.ISBN,
                DateAchat = entity.DateAchat,
            };
        }

        public static BLL.Adresses ToBLL(this DTO.Forms.AdressesFormDTO entity)
        {
            return new BLL.Adresses
            {
                
                Pays = entity.Pays,
                Localite = entity.Localite,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Boite = entity.Boite,
                UtilisateurId = entity.UtilisateurId,

            };
        }

        public static DTO.Forms.AdressesFormDTO ToAPI(this BLL.Adresses entity)
        {
            return new DTO.Forms.AdressesFormDTO
            {
                
                Pays = entity.Pays,
                Localite = entity.Localite,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Boite = entity.Boite,
                UtilisateurId = entity.UtilisateurId,

            };
        }
        public static DTO.Forms.AuteursFormDTO ToAPI(this BLL.Auteurs entity)
        {
            return new DTO.Forms.AuteursFormDTO
            {
                IDauteur = entity.IDauteur,
                Nom = entity.Nom,
                Prenom = entity.Prenom,

            };
        }

        public static BLL.Auteurs ToBLL(this DTO.Forms.AuteursFormDTO entity)
        {
            return new BLL.Auteurs
            {
                
                Nom = entity.Nom,
                Prenom = entity.Prenom,

            };
        }

       
        public static DTO.Forms.GenresFormDTO ToAPI(this BLL.Genres entity)
        {
            return new DTO.Forms.GenresFormDTO
            {
                IDgenre = entity.IDgenre,
                Nom = entity.Nom,
            };
        }

        //public static BLL.Genres ToBLL(this DTO.Forms.GenresFormDTO entity)
        //{
        //    return new BLL.Genres
        //    {
        //        IDgenre = entity.IDgenre,
        //        Nom = entity.Nom,
        //    };
        //}

        public static DTO.Forms.LocationsFormDTO ToAPI(this BLL.Locations entity)
        {
            return new DTO.Forms.LocationsFormDTO
            {
                IDlocation = entity.IDlocation,
                ISBN = entity.ISBN,
                IDutilisateur = entity.IDutilisateur,
                DateLocation = entity.DateLocation,
                DateRetour = entity.DateRetour,
            };
        }

        public static BLL.Locations ToBLL(this DTO.Forms.LocationsFormDTO entity)
        {
            return new BLL.Locations
            {
                
                ISBN = entity.ISBN,
                IDutilisateur = entity.IDutilisateur,
                DateLocation = entity.DateLocation,
                DateRetour = entity.DateRetour,
            };
        }
        public static DTO.Forms.UtilisateursFormDTO ToAPI(this BLL.Utilisateurs entity)
        {
            return new DTO.Forms.UtilisateursFormDTO
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

        public static BLL.Utilisateurs ToBLL(this DTO.Forms.UtilisateursFormDTO entity)
        {
            return new BLL.Utilisateurs
            {
                
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

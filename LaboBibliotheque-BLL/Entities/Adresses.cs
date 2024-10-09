﻿using LaboBibliotheque_Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace LaboBibliotheque_BLL.Entities
{
    public class Adresses : IAdresses

    {
        
        public int IDadresse { get; internal set; }

        public string Pays { get; set; }
      
        public string Localite { get; set; }
     
        public string Rue { get; set; }
       
        public int Numero { get; set; }
        public int Boite { get; set; }
      
        public int UtilisateurId { get; set; }


    }
}

﻿using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Achats : IAchats
    {
        public int IDachat { get; internal set; }
        public int IDutilisateur { get; set; }
        public int ISBN { get; set; }
        public DateTime DateAchat { get; set; }

       
    }
}

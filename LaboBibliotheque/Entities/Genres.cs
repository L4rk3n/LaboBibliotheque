﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_DB.Entities
{
    public class Genres
    {
        public int IDgenre { get; set; }
        public string Nom { get; set; }

        public List <Livres> ListeLivres { get; set; }
    }
}

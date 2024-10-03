﻿using LaboBibliotheque_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_Common.Repositories
{
    public interface IGenresRepository<TGenre> : ICRUDRepository<TGenre, int> where TGenre : IGenres
    {
        
    }
}

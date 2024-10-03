using LaboBibliotheque_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque_Common.Repositories
{
    public interface IAuteursRepository<TAuteur> : ICRUDRepository<TAuteur, int> where TAuteur : IAuteurs
    {
        
    }
}


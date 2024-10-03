
using LaboBibliotheque_Common.Entities;
using LaboBibliotheque_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LaboBibliotheque_Common.Repositories
{
    public interface IUtilisateursRepository<TUtilisateur> : ICRUDRepository<TUtilisateur, int> where TUtilisateur : IUtilisateurs
    {
        
    }
}

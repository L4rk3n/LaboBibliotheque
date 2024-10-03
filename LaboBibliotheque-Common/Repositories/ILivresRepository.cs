using LaboBibliotheque_Common.Entities;
using LaboBibliotheque_Common.Repositories;

namespace LaboBibliotheque_Common.Repositories
{
    public interface ILivresRepository<TLivres> : ICRUDRepository<TLivres, int> where TLivres : ILivres
    {
        
    }
}

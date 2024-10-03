using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_Common.Repositories
{
    public interface IAchatsRepository<TAchats> : ICRUDRepository<TAchats, int> where TAchats : IAchats
    {
        
    }
}

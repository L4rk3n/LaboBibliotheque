using LaboBibliotheque_Common.Entities;
namespace LaboBibliotheque_Common.Repositories
{
    public interface ICRUDRepository<TEntity, TId> where TEntity : IEntity
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(TId id);
        public bool Create(TEntity entity);
        public void Update(TId id, TEntity entity);
        public void Delete(TId id);
    }
}

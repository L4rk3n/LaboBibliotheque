using LaboBibliotheque_Common.Entities;
namespace LaboBibliotheque_Common.Repositories
{
    public interface ICRUDRepository2<TEntity, TId> where TEntity : IEntity
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(TId id);
        public TEntity Get(string email);
        public bool Create(TEntity entity);
        public void Update(TId id, TEntity entity);
        public void Delete(TId id);
    }
}

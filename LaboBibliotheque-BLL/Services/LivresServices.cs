
using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_BLL.Mapper;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;

namespace LaboBibliotheque_BLL.Services
{
    public class LivresServices : ILivresRepository<Livres>
    {
        private DataContext _context;

        public LivresServices(DataContext context)
        {
            _context = context;
        }

        public bool Create(Livres entity)
        {
            try
            {
                _context.Livres.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            _context.Livres.Remove(_context.Livres.First(a => a.ISBN == id));
            _context.SaveChanges();
        }

        public IEnumerable<Livres> Get()
        {
            try
            {
                return _context.Livres.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Livres>();
            }
        }

        public Livres Get(int id)
        {
            try
            {
                return _context.Livres.First(l => l.ISBN == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Livres();
            }
        }

        public void Update(int id, Livres entity)
        {
            try
            {
                var livres = _context.Livres.First(l => l.ISBN == id);
                livres.Titre = entity.Titre;
                livres.IDgenre = entity.IDgenre;
                livres.Prix = entity.Prix;
                livres.stocklocation = entity.Stocklocation;
                livres.stockachat = entity.Stockachat;
                
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }

    }
}

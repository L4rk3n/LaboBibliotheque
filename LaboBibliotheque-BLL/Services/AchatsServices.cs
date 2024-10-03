using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_BLL.Mapper;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;

namespace LaboBibliotheque_BLL.Services
{
    public class AchatsServices : IAchatsRepository<Achats>
    {
        private DataContext _context;

        public AchatsServices(DataContext context)
        {
            _context = context;
        }

        public bool Create(Achats entity)
        {
            try
            {
                _context.Achats.Add(entity.ToEF());
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
            _context.Achats.Remove(_context.Achats.First(a => a.IDachat == id));
            _context.SaveChanges();
        }

        public IEnumerable<Achats> Get()
        {
            try
            {
                return _context.Achats.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Achats>();
            }
        }

        public Achats Get(int id)
        {
            try
            {
                return _context.Achats.First(l => l.IDachat == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Achats();
            }
        }

        public void Update(int id, Achats entity)
        {
            try
            {
                var Achats = _context.Achats.First(l => l.IDachat == id);
                Achats.IDutilisateur = entity.IDutilisateur;
                Achats.ISBN = entity.ISBN;
                Achats.DateAchat = entity.DateAchat;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }

    }
}

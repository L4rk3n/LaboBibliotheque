using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_BLL.Mapper;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;

namespace LaboBibliotheque_BLL.Services
{
    public class AuteursServices : IAuteursRepository<Auteurs>
    {
        private DataContext _context;

        public AuteursServices(DataContext context)
        {
            _context = context;
        }

        public bool Create(Auteurs entity)
        {
            try
            {
                _context.Auteurs.Add(entity.ToEF());
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
            _context.Auteurs.Remove(_context.Auteurs.First(a => a.IDauteur == id));
            _context.SaveChanges();
        }

        public IEnumerable<Auteurs> Get()
        {
            try
            {
                return _context.Auteurs.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Auteurs>();
            }
        }

        public Auteurs Get(int id)
        {
            try
            {
                return _context.Auteurs.First(l => l.IDauteur == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Auteurs();
            }
        }

        public void Update(int id, Auteurs entity)
        {
            try
            {
                var Auteurs = _context.Auteurs.First(l => l.IDauteur == id);
                Auteurs.Nom = entity.Nom;
                Auteurs.Prenom = entity.Prenom;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }
    }
}

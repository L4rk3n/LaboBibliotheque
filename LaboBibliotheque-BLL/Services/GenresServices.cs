using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_BLL.Mapper;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;

namespace LaboBibliotheque_BLL.Services
{
    public class GenresServices : IGenresRepository<Genres>
    {
        private DataContext _context;

        public GenresServices(DataContext context)
        {
            _context = context;
        }

        public bool Create(Genres entity)
        {
            try
            {
                _context.Genres.Add(entity.ToEF());
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
            _context.Genres.Remove(_context.Genres.First(a => a.IDgenre == id));
            _context.SaveChanges();
        }

        public IEnumerable<Genres> Get()
        {
            try
            {
                return _context.Genres.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Genres>();
            }
        }

        public Genres Get(int id)
        {
            try
            {
                return _context.Genres.First(l => l.IDgenre == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Genres();
            }
        }

        public void Update(int id, Genres entity)
        {
            try
            {
                var Genres = _context.Genres.First(l => l.IDgenre == id);
                Genres.Nom = entity.Nom;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }
    }
}

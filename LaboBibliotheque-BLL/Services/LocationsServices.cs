using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_BLL.Mapper;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;

namespace LaboBibliotheque_BLL.Services
{
    public class LocationsServices : ILocationsRepository<Locations>
    {
        private DataContext _context;

        public LocationsServices(DataContext context)
        {
            _context = context;
        }

        public bool Create(Locations entity)
        {
            try
            {
                _context.Locations.Add(entity.ToEF());
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
            _context.Locations.Remove(_context.Locations.First(a => a.IDlocation == id));
            _context.SaveChanges();
        }

        public IEnumerable<Locations> Get()
        {
            try
            {
                return _context.Locations.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Locations>();
            }
        }

        public Locations Get(int id)
        {
            try
            {
                return _context.Locations.First(l => l.IDlocation == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Locations();
            }
        }

        public void Update(int id, Locations entity)
        {
            try
            {
                var Locations = _context.Locations.First(l => l.IDlocation == id);
                Locations.ISBN = entity.ISBN;
                Locations.IDutilisateur = entity.IDutilisateur;
                Locations.DateLocation = entity.DateLocation;
                Locations.DateRetour = entity.DateRetour;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }
    }
}

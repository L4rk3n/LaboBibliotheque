using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_BLL.Mapper;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;

namespace LaboBibliotheque_BLL.Services
{
    public class AdressesServices : IAdressesRepository<Adresses>
    {
        private DataContext _context;

        public AdressesServices(DataContext context)
        {
            _context = context;
        }

        public bool Create(Adresses entity)
        {
            try
            {
                _context.Adresses.Add(entity.ToEF());
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
            _context.Adresses.Remove(_context.Adresses.First(a => a.IDadresse == id));
            _context.SaveChanges();
        }

        public IEnumerable<Adresses> Get()
        {
            try
            {
                return _context.Adresses.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Adresses>();
            }
        }

        public Adresses Get(int id)
        {
            try
            {
                return _context.Adresses.First(l => l.IDadresse == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Adresses();
            }
        }

        public void Update(int id, Adresses entity)
        {
            try
            {
                var Adresses = _context.Adresses.First(l => l.IDadresse == id);
                Adresses.Pays = entity.Pays;
                Adresses.Localite = entity.Localite;
                Adresses.Rue = entity.Rue;
                Adresses.Numero = entity.Numero;
                Adresses.Boite = entity.Boite;
                Adresses.UtilisateurId = entity.UtilisateurId;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }
    }
}

using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_BLL.Mapper;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;


namespace LaboBibliotheque_BLL.Services
{
    public class UtilisateursServices : IUtilisateursRepository<Utilisateurs>
    {
        private DataContext _context;

        public UtilisateursServices(DataContext context)
        {
            _context = context;
        }

        public bool Create(Utilisateurs entity)
        {
            try
            {
                _context.Utilisateurs.Add(entity.ToEF());
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
            _context.Utilisateurs.Remove(_context.Utilisateurs.First(a => a.IDutilisateur == id));
            _context.SaveChanges();
        }

        public IEnumerable<Utilisateurs> Get()
        {
            try
            {
                return _context.Utilisateurs.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Utilisateurs>();
            }
        }

        public Utilisateurs Get(int id)
        {
            try
            {
                return _context.Utilisateurs.First(l => l.IDutilisateur == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Utilisateurs();
            }
        }

        public void Update(int id, Utilisateurs entity)
        {
            try
            {
                var Utilisateurs = _context.Utilisateurs.First(l => l.IDutilisateur == id);
                Utilisateurs.IDadresse = entity.IDadresse;
                Utilisateurs.Nom = entity.Nom;
                Utilisateurs.Prenom = entity.Prenom;
                Utilisateurs.DateNaissance = entity.DateNaissance;
                Utilisateurs.Email = entity.Email;
                Utilisateurs.Password = entity.Password;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }
    }
}
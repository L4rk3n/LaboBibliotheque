using LaboBibliotheque_Common.Entities;

namespace LaboBibliotheque_BLL.Entities
{
    public class Ecrits : IEcrits
    {
        public int ISBN { get; set; }
        public int IDauteur { get; set; }
    }
}

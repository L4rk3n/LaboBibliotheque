using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque.Entities
{
    public class Stocks
    {
        public int IDstock { get; set; }
        public int ISBN { get; set; }
        public int IDbibliotheque { get; set; }
        public int stocklocation { get; set; }
        public int stockachat { get; set; }
    }
}

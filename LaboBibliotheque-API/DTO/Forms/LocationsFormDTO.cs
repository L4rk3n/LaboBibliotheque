using System.ComponentModel.DataAnnotations;

namespace LaboBibliotheque_API.DTO.Forms
{
    public class LocationsFormDTO
    {
        
        public int IDlocation { get;set; }
        [Required]
        public int ISBN { get; set; }
        [Required]
        public int IDutilisateur { get; set; }
        [Required]
        public DateTime DateLocation { get; set; }
        [Required]
        public DateTime DateRetour { get; set; }
    }
}

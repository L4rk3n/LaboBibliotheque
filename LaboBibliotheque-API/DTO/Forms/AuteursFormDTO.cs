using System.ComponentModel.DataAnnotations;

namespace LaboBibliotheque_API.DTO.Forms
{
    public class AuteursFormDTO
    {
        
        public int IDauteur { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
    }
}

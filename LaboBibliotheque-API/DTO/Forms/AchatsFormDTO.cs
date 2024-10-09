using System.ComponentModel.DataAnnotations;

namespace LaboBibliotheque_API.DTO.Forms
{
    public class AchatsFormDTO
    {
        
        public int IDachat { get; set; }
        [Required]
        public int IDutilisateur { get; set; }
        [Required]
        public int ISBN { get; set; }
        [Required]
        public DateTime DateAchat { get; set; }
    }
}

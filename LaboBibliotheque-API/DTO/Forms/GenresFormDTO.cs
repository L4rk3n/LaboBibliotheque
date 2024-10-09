using System.ComponentModel.DataAnnotations;

namespace LaboBibliotheque_API.DTO.Forms
{
    public class GenresFormDTO
    {
        
        public int IDgenre { get; internal set; }
        [Required]
        public string Nom { get; internal set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace LaboBibliotheque_API.DTO.Forms
{
    public class LivresFormDTO
    {
        
        public int ISBN { get;set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        public int IDgenre { get; set; }
        [Required]
        public double Prix { get; set; }
        [Required]
        public int StockLocation { get; set; }
        [Required]
        public int StockAchat { get; set; }
    }
}

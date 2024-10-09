using System.ComponentModel.DataAnnotations;

namespace LaboBibliotheque_API.DTO.Forms
{
    public class AdressesFormDTO
    {
        
        public int IDadresse { get; set; }
        [Required]
        public string Pays { get; set; }
        [Required]
        public string Localite { get; set; }
        [Required]
        public string Rue { get; set; }
        [Required]
        public int Numero { get; set; }
        
        public int Boite { get; set; }
        [Required]
        public int UtilisateurId { get; set; }
    }
}

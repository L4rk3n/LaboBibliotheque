
using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_API.DTO.Forms;
using LaboBibliotheque_API.Services;

namespace LaboBibliotheque_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUtilisateursRepository<Utilisateurs> _UtilisateursServices;

        private readonly TokenService _tokenService;

        public AuthController(IUtilisateursRepository<Utilisateurs> utilisateursServices, TokenService tokenService)
        {
            _UtilisateursServices = utilisateursServices;
            _tokenService = tokenService;
        }



        [HttpPost]
        public IActionResult Login(AuthFormDTO authFormDTO) {

            Utilisateurs? utilisateur = _UtilisateursServices.Get(authFormDTO.Email);

            if (utilisateur is null)
                return BadRequest();
            
            if (authFormDTO.Password != utilisateur.Password)
                return BadRequest();

            // to do generer le token a renvoyer dans le ok 
            return Ok(new { token = _tokenService.GenerateJwt(utilisateur) });
                       
        }
    }
}


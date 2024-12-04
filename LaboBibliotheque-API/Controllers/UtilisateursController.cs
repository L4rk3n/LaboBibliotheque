using LaboBibliotheque_API.DTO.Forms;
using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_API.Tools;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_BLL.Entities;
using Microsoft.AspNetCore.Authorization;

namespace LaboBibliotheque_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {

        private readonly IUtilisateursRepository<Utilisateurs> _UtilisateursServices;

        public UtilisateursController(IUtilisateursRepository<Utilisateurs> UtilisateursServices)
        {
            _UtilisateursServices = UtilisateursServices;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_UtilisateursServices.Get());
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create([FromBody] UtilisateursFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                _UtilisateursServices.Create(form.ToBLL());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return Ok();
        }
        
        [HttpGet("byUtilisateurs/{id}")]
        public IActionResult GetByUtilisateursId(int id)
        {
            return Ok(_UtilisateursServices.Get(id));
        }

        [HttpGet("byEmail/{email}")]
        public IActionResult GetByemail(string email)
        {
            return Ok(_UtilisateursServices.Get(email));
        }

    }
}
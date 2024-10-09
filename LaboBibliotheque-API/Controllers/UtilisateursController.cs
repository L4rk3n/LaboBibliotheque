using LaboBibliotheque_API.DTO.Forms;
using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_API.Tools;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_BLL.Entities;

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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_UtilisateursServices.Get());
        }

        [HttpPost]
        public IActionResult Create([FromBody] UtilisateursFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _UtilisateursServices.Create(form.ToBLL());
            return Ok();
        }

        [HttpGet("byUtilisateurs/{id}")]
        public IActionResult GetByUtilisateursId(int id)
        {
            return Ok(_UtilisateursServices.Get(id));
        }

    }
}
using LaboBibliotheque_API.DTO.Forms;
using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_API.Tools;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_BLL.Entities;

namespace LaboBibliotheque_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuteursController : ControllerBase
    {

        private readonly IAuteursRepository<Auteurs> _AuteursServices;

        public AuteursController(IAuteursRepository<Auteurs> AuteursServices)
        {
            _AuteursServices = AuteursServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AuteursServices.Get());
        }

        [HttpPost]
        public IActionResult Create([FromBody] AuteursFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _AuteursServices.Create(form.ToBLL());
            return Ok();
        }

        [HttpGet("byAchats/{id}")]
        public IActionResult GetByAchatsId(int id)
        {
            return Ok(_AuteursServices.Get(id));
        }

    }
}
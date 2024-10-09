using LaboBibliotheque_API.DTO.Forms;
using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_API.Tools;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_BLL.Entities;

namespace LaboBibliotheque_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivresController : ControllerBase
    {

        private readonly ILivresRepository<Livres> _LivresServices;

        public LivresController(ILivresRepository<Livres> LivresServices)
        {
            _LivresServices = LivresServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_LivresServices.Get());
        }

        [HttpPost]
        public IActionResult Create([FromBody] LivresFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _LivresServices.Create(form.ToBLL());
            return Ok();
        }

        [HttpGet("byAchats/{id}")]
        public IActionResult GetByAchatsId(int id)
        {
            return Ok(_LivresServices.Get(id));
        }


    }
}
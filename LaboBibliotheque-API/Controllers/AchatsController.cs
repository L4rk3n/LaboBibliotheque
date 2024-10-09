using LaboBibliotheque_API.DTO.Forms;
using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_API.Tools;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_BLL.Entities;

namespace LaboBibliotheque_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchatsController : ControllerBase
    {

        private readonly IAchatsRepository<Achats> _AchatsServices;

        public AchatsController(IAchatsRepository<Achats> AchatsServices)
        {
            _AchatsServices = AchatsServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AchatsServices.Get());
        }

        [HttpPost]
        public IActionResult Create([FromBody] AchatsFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _AchatsServices.Create(form.ToBLL());
            return Ok();
        }

        [HttpGet("byAchats/{id}")]
        public IActionResult GetByAchatsId(int id)
        {
            return Ok(_AchatsServices.Get(id));
        }
        
    }
}

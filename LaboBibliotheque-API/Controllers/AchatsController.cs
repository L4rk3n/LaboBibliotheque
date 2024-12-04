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
    public class AchatsController : ControllerBase
    {

        private readonly IAchatsRepository<Achats> _AchatsServices;

        public AchatsController(IAchatsRepository<Achats> AchatsServices)
        {
            _AchatsServices = AchatsServices;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AchatsServices.Get());
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create([FromBody] AchatsFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _AchatsServices.Create(form.ToBLL());
            return Ok();
        }
        [Authorize]
        [HttpGet("byAchats/{id}")]
        public IActionResult GetByAchatsId(int id)
        {
            return Ok(_AchatsServices.Get(id));
        }
        
    }
}

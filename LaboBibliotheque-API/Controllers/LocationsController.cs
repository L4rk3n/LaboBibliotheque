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
    public class LocationsController : ControllerBase
    {

        private readonly ILocationsRepository<Locations> _LocationsServices;

        public LocationsController(ILocationsRepository<Locations> LocationsServices)
        {
            _LocationsServices = LocationsServices;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_LocationsServices.Get());
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create([FromBody] LocationsFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _LocationsServices.Create(form.ToBLL());
            return Ok();
        }
        [Authorize]
        [HttpGet("byLocations/{id}")]
        public IActionResult GetByLocationsId(int id)
        {
            return Ok(_LocationsServices.Get(id));
        }

    }
}
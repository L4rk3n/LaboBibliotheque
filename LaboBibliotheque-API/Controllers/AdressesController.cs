﻿using LaboBibliotheque_API.DTO.Forms;
using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_API.Tools;
using LaboBibliotheque_BLL.Entities;
using LaboBibliotheque_Common.Repositories;

namespace LaboBibliotheque_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {

        private readonly IAdressesRepository<Adresses> _AdressesServices;

        public AdressesController(IAdressesRepository<Adresses> AdressesServices)
        {
            _AdressesServices = AdressesServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AdressesServices.Get());
        }

        [HttpPost]
        public IActionResult Create([FromBody] AdressesFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _AdressesServices.Create(form.ToBLL());
            return Ok();
        }

        [HttpGet("byAdresses/{id}")]
        public IActionResult GetByAchatsId(int id)
        {
            return Ok(_AdressesServices.Get(id));
        }


    }
}
﻿using Microsoft.AspNetCore.Mvc;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_BLL.Entities;
using Microsoft.AspNetCore.Authorization;

namespace LaboBibliotheque_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {

        private readonly IGenresRepository<Genres> _GenresServices;

        public GenresController(IGenresRepository<Genres> GenresServices)
        {
            _GenresServices = GenresServices;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_GenresServices.Get());
        }


        [Authorize]
        [HttpGet("byAdresses/{id}")]
        public IActionResult GetByAchatsId(int id)
        {
            return Ok(_GenresServices.Get(id));
        }


    }
}
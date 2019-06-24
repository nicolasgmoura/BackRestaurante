using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackRestaurante.Domain.Entities;
using BackRestaurante.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackRestaurante.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {

        private IServiceRestaurante _service;
        public RestauranteController(IServiceRestaurante service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/restaurante/getone/id
        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            try
            {
                return Ok(_service.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Restaurante restaurante)
        {
            try
            {
                if (restaurante == null)
                    return BadRequest("Objeto inválido");

                _service.Insert(restaurante);

                return Created("getone", new { id = restaurante.IdRestaurante });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Restaurante restaurante)
        {
            try
            {
                if (restaurante == null)
                    return BadRequest("Objeto inválido");

                _service.Update(id, restaurante);

                return NoContent();

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
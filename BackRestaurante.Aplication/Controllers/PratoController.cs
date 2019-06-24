using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackRestaurante.Domain.Entities;
using BackRestaurante.Domain.Interfaces;
using BackRestaurante.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackRestaurante.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
{

        private IServicePrato _service;
        public PratoController(IServicePrato service)
        {
            _service = service;
        }


        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

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
        public IActionResult create([FromBody] Prato prato)
        {
            try
            {
                if (prato == null)
                    return BadRequest("Objeto inválido");

                _service.Insert(prato);

                return Created("getone", new { id = prato.IdPrato });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult update(int id, [FromBody] Prato prato)
        {
            try
            {
                if (prato == null)
                    return BadRequest("Objeto inválido");

                _service.Update(id, prato);

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
                //Prato model = _service.GetOne(id);

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
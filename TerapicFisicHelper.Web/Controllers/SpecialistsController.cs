using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using TerapicFisicHelper.Data;
using TerapicFisicHelper.Entities;
using TerapicFisicHelper.Web.Models;

namespace TerapicFisicHelper.Web.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SpecialistsController : ControllerBase
    {
        private readonly DbContextTerapicFisicHelperApp _context;

        public SpecialistsController(DbContextTerapicFisicHelperApp context)
        {
            _context = context;
        }

        // GET: api/Specialists
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener la credencial de especialista")]
        [HttpGet]
        public async Task<IEnumerable<SpecialistModel>> GetSpecialists()
        {
            var specialistList = await _context.Specialists.ToListAsync();

            return specialistList.Select(c => new SpecialistModel
            {
                Id = c.Id,
                Specialty = c.Specialty,
                UserId = c.UserId
            });
        }

        // POST: api/Specialists
        [SwaggerOperation(Summary = "Esta ruta permite crear la credencial de especialista a un usuario")]
        [HttpPost]
        public async Task<IActionResult> PostSpecialist([FromBody] CreateSpecialistModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Specialist specialist = new Specialist
            {
                Specialty = model.Specialty,
                UserId = model.UserId
            };

            _context.Specialists.Add(specialist);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        // GET: api/Specialists/5
        [SwaggerOperation(Summary = "Esta ruta permite obtener la credencial de especialista a un usuario segun su id")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecialistById([FromRoute] int id)
        {
            var spec = await _context.Specialists.FindAsync(id);

            if (spec == null)
            {
                return NotFound();
            }

            return Ok(new SpecialistModel
            {
                Id = spec.Id,
                Specialty = spec.Specialty,
                UserId = spec.UserId
            });
        }

        // PUT: api/Specialists/5
        [SwaggerOperation(Summary = "Esta ruta permite actualizar la credencial de especialista a un usuario")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecialist(int id, [FromBody] UpdateSpecialistModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id <= 0)
                return BadRequest();

            var spec = await _context.Specialists.FirstOrDefaultAsync(c => c.Id == id);

            if (spec == null)
                return NotFound();

            spec.Specialty = model.Specialty;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // DELETE: api/Specialists/5
        [SwaggerOperation(Summary = "Esta ruta permite borrar la credencial de especialista a un usuario")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecialist([FromRoute] int id)
        {
            var spec = await _context.Specialists.FindAsync(id);

            if (spec == null)
                return NotFound();

            _context.Specialists.Remove(spec);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}

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
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EquipamentsController : ControllerBase
    {
        private readonly DbContextTerapicFisicHelperApp _context;

        public EquipamentsController(DbContextTerapicFisicHelperApp context)
        {
            _context = context;
        }

        // GET: api/Equipaments
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener la primera herramienta creada")]
        [HttpGet]
        public async Task<IEnumerable<EquipamentModel>> GetEquipaments()
        {
            var equipamentList = await _context.Equipaments.ToListAsync();

            return equipamentList.Select(c => new EquipamentModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
            });
        }

        // POST: api/Equipaments
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario crear una nueva herramienta a utilizar")]
        [HttpPost]
        public async Task<IActionResult> PostEquipament([FromBody] CreateEquipamentModel model)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Equipament equipament = new Equipament
            {
                Name = model.Name,
                Description = model.Description,
            };

            _context.Equipaments.Add(equipament);

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

        // GET: api/Equipaments/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener la herramienta segun su id")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEquipamentById([FromRoute] int id)
        {
            var equipament = await _context.Equipaments.FindAsync(id);

            if (equipament == null)
            {
                return NotFound();
            }

            return Ok(new EquipamentModel
            {
                Id = equipament.Id,
                Name = equipament.Name,
                Description = equipament.Description,
            });
        }

        // PUT: api/Equipaments/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario actualizar la herramienta segun su id")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipament(int id, [FromBody] UpdateEquipamentModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id <= 0)
                return BadRequest();

            var equipament = await _context.Equipaments.FirstOrDefaultAsync(c => c.Id == id);

            if (equipament == null)
                return NotFound();

            equipament.Name = model.Name;
            equipament.Description = model.Description;

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

        // DELETE: api/Equipaments/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario eliminar la herramienta segun su id")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipament([FromRoute]int id)
        {
            var equipament = await _context.Equipaments.FindAsync(id);

            if (equipament == null)
                return NotFound();

            _context.Equipaments.Remove(equipament);

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

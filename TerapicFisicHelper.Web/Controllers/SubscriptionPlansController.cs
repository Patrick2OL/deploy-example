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
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionPlansController : ControllerBase
    {
        private readonly DbContextTerapicFisicHelperApp _context;

        public SubscriptionPlansController(DbContextTerapicFisicHelperApp context)
        {
            _context = context;
        }

        // GET: api/SubscriptionPlans
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener el ultimo plan de subscripcion creado")]
        [HttpGet]
        public async Task<IEnumerable<SubscriptionPlanModel>> GetSubscriptionPlans()
        {
            var subscriptionList = await _context.SubscriptionPlans.ToListAsync();

            return subscriptionList.Select(c => new SubscriptionPlanModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Cost = c.Cost
            });
        }

        // POST: api/SubscriptionPlans
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario inscribirse a los diversos planes de la aplicación")]
        [HttpPost]
        public async Task<IActionResult> PostSubscriptionPlan([FromBody] CreateSubscriptionPlanModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            SubscriptionPlan subscriptionPlan = new SubscriptionPlan
            {
                Name = model.Name,
                Description = model.Description,
                Cost = model.Cost
            };

            _context.SubscriptionPlans.Add(subscriptionPlan);

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

        // GET: api/SubscriptionPlans/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener un plan de subscripcion segun su id")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubscriptionPlanById([FromRoute] int id)
        {
            var subscriptionPlan = await _context.SubscriptionPlans.FindAsync(id);

            if (subscriptionPlan == null)
            {
                return NotFound();
            }

            return Ok(new SubscriptionPlanModel
            {
                Id = subscriptionPlan.Id,
                Name = subscriptionPlan.Name,
                Description = subscriptionPlan.Description,
                Cost = subscriptionPlan.Cost
            });
        }

        // PUT: api/SubscriptionPlans/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario actualizar un plan de subscripcion")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubscriptionPlan(int id, [FromBody] UpdateSubscriptionPlanModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id <= 0)
                return BadRequest();

            var subscriptionPlan = await _context.SubscriptionPlans.FirstOrDefaultAsync(c => c.Id == id);

            if (subscriptionPlan == null)
                return NotFound();

            subscriptionPlan.Name = model.Name;
            subscriptionPlan.Description = model.Description;
            subscriptionPlan.Cost = model.Cost;

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

        // DELETE: api/SubscriptionPlans/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario eliminar un plan de subscripcion")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscriptionPlan([FromRoute] int id)
        {
            var subscriptionPlan = await _context.SubscriptionPlans.FindAsync(id);

            if (subscriptionPlan == null)
                return NotFound();

            _context.SubscriptionPlans.Remove(subscriptionPlan);

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

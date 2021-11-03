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
    public class HistoriesController : ControllerBase
    {
        private readonly DbContextTerapicFisicHelperApp _context;

        public HistoriesController(DbContextTerapicFisicHelperApp context)
        {
            _context = context;
        }

        // GET: api/Histories
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener los historiales creados")]
        [HttpGet]
        public async Task<IEnumerable<HistoryModel>> GetHistories()
        {
            var historyList = await _context.Histories.ToListAsync();

            return historyList.Select(c => new HistoryModel
            {
                CustomerId = c.CustomerId,
                SessionId = c.SessionId,
                Watched = c.Watched
            });
        }

        // POST: api/Histories
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario crear un historial")]
        [HttpPost]
        public async Task<IActionResult> PostHistory([FromBody] CreateHistoryModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            History history = new History
            {
                CustomerId = model.CustomerId,
                SessionId = model.SessionId,
                Watched = model.Watched
            };

            _context.Histories.Add(history);

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

        // GET: api/customers/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener un historial segun el id de los clientes participantes en la session")]
        [HttpGet("customers/{customerId}")]
        public async Task<IActionResult> GetAllByCustomerId([FromRoute] int customerId)
        {
            var session = await _context.Customers.FindAsync(customerId);

            if (session == null)
            {
                return NotFound();
            }

            return Ok(new CustomerModel
            {
                Id = session.Id,
                Description = session.Description,
                UserId = session.UserId
            });
        }

        // GET: api/session/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener un historial segun el id de la session")]
        [HttpGet("sessions/{sessionId}")]
        public async Task<IActionResult> GetAllBySessionId([FromRoute] int sessionId)
        {
            var customer = await _context.Sessions.FindAsync(sessionId);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(new SessionModel
            {
                Id = customer.Id,
                SpecialistId = customer.SpecialistId,
                Title = customer.Title,
                Description = customer.Description,
                StartDate = customer.StartDate,
                StartHour = customer.StartHour,
                EndHour = customer.EndHour
            });
        }
    }
}

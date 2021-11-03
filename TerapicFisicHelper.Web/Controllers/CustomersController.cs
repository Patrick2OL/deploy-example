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
    public class CustomersController : ControllerBase
    {
        private readonly DbContextTerapicFisicHelperApp _context;

        public CustomersController(DbContextTerapicFisicHelperApp context)
        {
            _context = context;
        }

        // GET: api/Customers
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener su descripción como cliente ")]
        [HttpGet]
        public async Task<IEnumerable<CustomerModel>> GetCustomers()
        {
            var customerList = await _context.Customers.ToListAsync();

            return customerList.Select(c => new CustomerModel
            {
                Id = c.Id,
                Description = c.Description,
                UserId = c.UserId
            });
        }

        // POST: api/Customers
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario crear una descripción de un cliente ")]
        [HttpPost]
        public async Task<IActionResult> PostCustomer([FromBody] CreateCustomerModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Customer customer = new Customer
            {
                Description = model.Description,
                UserId = model.UserId
            };

            _context.Customers.Add(customer);

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

        // GET: api/Customers/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener una descripción de un cliente segun su id")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] int id)
        {
            var cust = await _context.Customers.FindAsync(id);

            if (cust == null)
            {
                return NotFound();
            }

            return Ok(new CustomerModel
            {
                Id = cust.Id,
                Description = cust.Description,
                UserId = cust.UserId
            });
        }

        // PUT: api/Customers/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario actualizar una descripción de un cliente ")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, [FromBody] UpdateCustomerModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id <= 0)
                return BadRequest();

            var cust = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);

            if (cust == null)
                return NotFound();

            cust.Description = model.Description;

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

        // DELETE: api/Customers/5
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario eliminar una descripción de un cliente")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] int id)
        {
            var cust = await _context.Customers.FindAsync(id);

            if (cust == null)
                return NotFound();

            _context.Customers.Remove(cust);

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

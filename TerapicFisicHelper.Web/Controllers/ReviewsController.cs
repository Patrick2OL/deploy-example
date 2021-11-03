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
    public class ReviewsController : ControllerBase
    {
        private readonly DbContextTerapicFisicHelperApp _context;

        public ReviewsController(DbContextTerapicFisicHelperApp context)
        {
            _context = context;
        }

        // GET: api/Reviews
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener la ultima review realizada")]
        [HttpGet]
        public async Task<IEnumerable<ReviewModel>> GetReviews()
        {
            var reviewList = await _context.Reviews.ToListAsync();

            return reviewList.Select(c => new ReviewModel
            {
                Description = c.Description,
                Rank = c.Rank,
                CustomerId = c.CustomerId,
                SpecialistId = c.SpecialistId
            });
        }

        // POST: api/Reviews
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario crear una review de las sesiones")]
        [HttpPost]
        public async Task<IActionResult> PostReview([FromBody] CreateReviewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Review review = new Review
            {
                Description = model.Description,
                Rank = model.Rank,
                CustomerId = model.CustomerId,
                SpecialistId = model.SpecialistId
            };

            _context.Reviews.Add(review);

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

        // GET: api/Reviews/customerId
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener una review segun el id de un cliente")]
        [HttpGet("customers/{customerId}")]
        public async Task<IActionResult> GetAllByCustomerId(int customerId)
        {
            var specialist = await _context.Customers.FindAsync(customerId);

            if (specialist == null)
            {
                return NotFound();
            }

            return Ok(new CustomerModel
            {
                Id = specialist.Id,
                Description = specialist.Description,
                UserId = specialist.UserId
            });
        }

        // GET: api/Reviews/sessionId
        [SwaggerOperation(Summary = "Esta ruta permite a un usuario obtener una review segun el id de la sesion donde se realizó")]
        [HttpGet("specialists/{specialistId}")]
        public async Task<IActionResult> GetAllBySpecialistId(int specialistId)
        {
            var customer = await _context.Specialists.FindAsync(specialistId);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(new SpecialistModel
            {
                Id = customer.Id,
                Specialty = customer.Specialty,
                UserId = customer.UserId
            });
        }
    }
}

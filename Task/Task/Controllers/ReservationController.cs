using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IRepository repository;

        public ReservationController(IRepository repos) => repository = repos;

        [HttpGet]
        public async Task<IEnumerable<Reservation>> Get()
        {
            return await repository.GetReservationsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request body");
            }

            var reservation = await repository.GetReservationByIdAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }

        [HttpPost]
        public async Task<ActionResult<Reservation>> Post([FromBody] Reservation res)
        {
            var createdReservation = await repository.AddReservation(res);
            return CreatedAtAction(nameof(Get), new { id = createdReservation.Id }, createdReservation);
        }

        [HttpPut]
        public async Task<ActionResult<Reservation>> Put([FromBody] Reservation res)
        {
            var updatedReservation = await repository.UpdateReservation(res);
            return Ok(updatedReservation);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await repository.DeleteReservation(id);
            return NoContent();
        }
    }
}

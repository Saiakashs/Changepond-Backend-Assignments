using EFTasks.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFTasks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly ILogger<ReservationController> _logger;
        private readonly IRepository repository;

        public ReservationController(ILogger<ReservationController> logger, IRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> Get()
        {
            var reservations = await repository.GetReservationsAsync();
            return Ok(reservations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID.");
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
            if (res == null)
            {
                return BadRequest("Reservation cannot be null.");
            }

            var addedReservation = await repository.AddReservationAsync(res);
            return CreatedAtAction(nameof(Get), new { id = addedReservation.Id }, addedReservation);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Reservation>> Put(int id, [FromBody] Reservation res)
        {
            if (id <= 0 || res == null)
            {
                return BadRequest("Invalid data.");
            }

            res.Id = id; // Ensure we set the ID for update
            var updatedReservation = await repository.UpdateReservationAsync(res);
            return Ok(updatedReservation);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID.");
            }

            await repository.DeleteReservationAsync(id);
            return NoContent(); // Return 204 No Content
        }
    }
}
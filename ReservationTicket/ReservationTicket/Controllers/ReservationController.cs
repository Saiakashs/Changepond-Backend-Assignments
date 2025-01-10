using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationTicket.Models;

namespace ReservationTicket.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationContext context;

        public ReservationController(ReservationContext cc)
        {
            context = cc;
        }

        // GET: api/Reservation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservation()
        {
            return await context.Reservations.ToListAsync();
        }

        // GET: api/Reservation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                return NotFound();
            }

            return reservation;
        }

        // POST: api/Reservation
        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetReservation", new { id = reservation.Id }, reservation);
        }

        // PUT: api/Reservation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservation(int id, Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return BadRequest();
            }

            context.Entry(reservation).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Reservation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            context.Reservations.Remove(reservation);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return context.Reservations.Any(e => e.Id == id);
        }
    }
}

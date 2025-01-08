using Microsoft.EntityFrameworkCore;
using Task.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FullStackAPI.Models
{
    public class Repository : IRepository
    {
        private readonly CompanyContext context;

        public Repository(CompanyContext cc)
        {
            context = cc;

            // Initial reservations can be seeded in the database context
        }

        public async Task<Reservation> AddReservation(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            await context.SaveChangesAsync();
            return reservation;
        }

        public async System.Threading.Tasks.Task DeleteReservation(int id)
        {
            var reservation = await context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                context.Reservations.Remove(reservation);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Reservation> UpdateReservation(Reservation reservation)
        {
            context.Reservations.Update(reservation);
            await context.SaveChangesAsync();
            return reservation;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsAsync()
        {
            return await context.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            return await context.Reservations.FindAsync(id);
        }
    }
}

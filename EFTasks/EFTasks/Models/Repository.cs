using EFTasks.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTasks.Models
{
    public class Repository : IRepository
    {
        private readonly ReservationContext context;

        public Repository(ReservationContext context)
        {
            this.context = context;

            // Seed initial data only if there are no existing reservations
            if (!context.Reservations.Any())
            {
                var reservations = new List<Reservation>
                {
                    new Reservation { Id = 1, Name = "Anbu", StartLocation = "Chennai", EndLocation = "Mumbai" },
                    new Reservation { Id = 2, Name = "Ajay", StartLocation = "Kanayakumari", EndLocation = "Mumbai" },
                    new Reservation { Id = 3, Name = "Manoj", StartLocation = "Chennai", EndLocation = "Madurai" },
                    new Reservation { Id = 4, Name = "Sanjay", StartLocation = "Chennai", EndLocation = "Thiruchi" },
                };
                context.Reservations.AddRange(reservations);
                context.SaveChanges();
            }
        }

        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            return await context.Reservations.FindAsync(id);
        }

        public async Task<IEnumerable<Reservation>> GetReservationsAsync()
        {
            return await context.Reservations.ToListAsync();
        }

        public async Task<Reservation> AddReservationAsync(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            await context.SaveChangesAsync();
            return reservation;
        }

        public async Task DeleteReservationAsync(int id)
        {
            var reservation = await GetReservationByIdAsync(id);
            if (reservation != null)
            {
                context.Reservations.Remove(reservation);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Reservation> UpdateReservationAsync(Reservation reservation)
        {
            context.Reservations.Update(reservation);
            await context.SaveChangesAsync();
            return reservation;
        }
    }
}
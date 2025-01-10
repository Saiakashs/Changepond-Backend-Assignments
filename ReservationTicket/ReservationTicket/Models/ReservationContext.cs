using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ReservationTicket.Models
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options) { }

        public DbSet<Reservation> Reservations { get; set; }
    }
}

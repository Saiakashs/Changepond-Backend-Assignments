using Microsoft.EntityFrameworkCore;

namespace Task.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, Name = "Sai", StartLocation = "Tirunelveli", EndLocation = "Chennai" },
                new Reservation { Id = 2, Name = "Arun", StartLocation = "Pondichery", EndLocation = "Chennai" },
                new Reservation { Id = 3, Name = "Karthik", StartLocation = "Kanyakumari", EndLocation = "Chennai" },
                new Reservation { Id = 4, Name = "Prasath", StartLocation = "Perambulur", EndLocation = "Chennai" }
                );
        }
    }
}

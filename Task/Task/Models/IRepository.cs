using System.Threading.Tasks;

namespace Task.Models
{
    public interface IRepository
    {
        System.Threading.Tasks.Task<Reservation> AddReservation(Reservation reservation);
        System.Threading.Tasks.Task<Reservation> UpdateReservation(Reservation reservation);
        System.Threading.Tasks.Task DeleteReservation(int id);
        System.Threading.Tasks.Task<IEnumerable<Reservation>> GetReservationsAsync();
        System.Threading.Tasks.Task<Reservation> GetReservationByIdAsync(int id);
    }
}
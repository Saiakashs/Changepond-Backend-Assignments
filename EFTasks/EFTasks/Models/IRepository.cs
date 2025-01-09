namespace EFTasks.Models
{
    public interface IRepository
    {
        Task<Reservation> AddReservationAsync(Reservation reservation);
        Task<Reservation> UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int id);
        Task<IEnumerable<Reservation>> GetReservationsAsync(); 
        Task<Reservation> GetReservationByIdAsync(int id); 
    }
}
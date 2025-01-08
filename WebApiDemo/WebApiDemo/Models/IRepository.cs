namespace WebApiDemo.Models
{
    public interface IRepository
    {

        public Reservation AddReservation(Reservation reservation);

        public Reservation UpdateReservation(Reservation reservation);

        public void DeleteReservation(int id);

        public IEnumerable<Reservation> Reservations { get; }

        public Reservation this[int id] { get; }
    }
}

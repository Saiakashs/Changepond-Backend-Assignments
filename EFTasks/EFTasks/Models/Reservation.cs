namespace EFTasks.Models
{
    public class Reservation
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty; 
        public string StartLocation { get; set; } = string.Empty; 
        public string EndLocation { get; set; } = string.Empty; 
    }
}
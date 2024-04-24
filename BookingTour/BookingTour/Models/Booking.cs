namespace BookingTour.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AdultTicket { get; set; } = 0;
        public int ChildTicket { get; set; } = 0;
        public bool status {  get; set; }
        public int TourId {  get; set; }
        public Tour? Tour { get; set; }
        public int UserId {  get; set; }    
        public User? User { get; set; }
    }
}

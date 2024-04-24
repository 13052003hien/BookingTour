namespace BookingTour.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Rate { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public int TourId { get; set; }
        public Tour? Tour { get; set; }
        public int UserId {  get; set; }
        public User? User { get; set; }
    }
}

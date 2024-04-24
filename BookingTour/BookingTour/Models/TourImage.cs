namespace BookingTour.Models
{
    public class TourImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int TourId { get; set; }
        public Tour? Tour { get; set; }
    }
}

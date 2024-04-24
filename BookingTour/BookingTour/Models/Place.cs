namespace BookingTour.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameDetail { get; set; }
        public List<Tour>? Tours { get; set; }
    }
}

namespace BookingTour.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly StartDay { get; set; }
        public DateOnly EndDay { get; set; }
        public decimal PercentPrice {  get; set; }
        public List<Tour>? Tours { get; set; }
    }
}

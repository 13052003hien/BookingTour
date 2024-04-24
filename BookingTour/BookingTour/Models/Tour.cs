
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace BookingTour.Models
{
    public class Tour
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public string Destination { get; set; }
        public string? Description { get; set; }
        public string? LanguageSp { get; set; }
        public string? Fits { get; set; }
        public string? Services { get; set; }
        public int Phone { get; set; }
        public string Time { get; set; }
        public decimal AdultPrice { get; set; }
        public decimal ChildPrice { get; set; }
        public string? Map { get; set; }
        public int Rate {  get; set; }
        public string? VideoUrl { get; set; }
        public List<TourImage>? Images { get; set; }
        public int PlaceId { get; set; }
        public Place? Place { get; set; }
        public int PromotionId { get; set; }
        public Promotion? Promotion { get; set; }
        public string TransportId {  get; set; }
        public Transport? Transport {  get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Review> Reviews { get; set; }
    }
}

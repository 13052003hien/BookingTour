using System.ComponentModel.DataAnnotations.Schema;

namespace BookingTour.Models
{
    public class Transport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public string DriverName { get; set; }
        public List<Tour> Tours { get; set; }

    }
}

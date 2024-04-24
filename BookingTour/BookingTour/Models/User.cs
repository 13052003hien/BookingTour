using System.ComponentModel.DataAnnotations;

namespace BookingTour.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}

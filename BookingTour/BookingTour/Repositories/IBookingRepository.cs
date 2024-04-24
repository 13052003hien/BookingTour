using BookingTour.Models;

namespace BookingTour.Repositories
{
    public interface IBookingRepository
    {
        //Tổng hợp phương thức từ EFBookingRepository
        Task<IEnumerable<Booking>> GetAllAsync();
        Task<Booking> GetByIdAsync(int id);
        Task AddAsync(Booking booking);
        Task UpdateAsync(Booking booking);
        Task DeleteAsync(int id);
        Task<IEnumerable<Booking>> GetByNameAsync(int SearchId);
        //Task<IEnumerable<Tour>> GetSortedAsync(string sortTour);
    }
}

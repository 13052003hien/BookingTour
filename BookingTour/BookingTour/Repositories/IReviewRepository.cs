using BookingTour.Models;

namespace BookingTour.Repositories
{
    public interface IReviewRepository
    {
        //Tổng hợp phương thức từ EFReviewRepository
        Task<IEnumerable<Review>> GetAllAsync();
        Task<Review> GetByIdAsync(int id);
        Task AddAsync(Review review);
        Task UpdateAsync(Review review);
        Task DeleteAsync(int id);
        Task<IEnumerable<Review>> GetByNameAsync(int SearchId);
        //Task<IEnumerable<Tour>> GetSortedAsync(string sortTour);
    }
}

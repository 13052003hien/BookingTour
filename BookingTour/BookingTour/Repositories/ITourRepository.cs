using BookingTour.Models;

namespace BookingTour.Repositories
{
    public interface ITourRepository
    {
        //Tổng hợp phương thức từ EFTourRepository
        Task<IEnumerable<Tour>> GetAllAsync();
        Task<Tour> GetByIdAsync(int id);
        Task AddAsync(Tour tour);
        Task UpdateAsync(Tour tour);
        Task DeleteAsync(int id);
        Task<IEnumerable<Tour>> GetByNameAsync(string SearchString);
        Task<IEnumerable<Tour>> GetSortedAsync(string sortTour);
    }
}

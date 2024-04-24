using BookingTour.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingTour.Repositories
{
    public class EFReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;
        public EFReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //Phương thức thêm review
        public async Task AddAsync(Review review)
        {
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }
        //Phương thức xoá review
        public async Task DeleteAsync(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
        }
        //Phương thức lấy ra tất cả review
        public async Task<IEnumerable<Review>> GetAllAsync()
        {
            return await _context.Reviews.ToListAsync();
            //return await _context.Tours.Include(p => p.Category).ToListAsync(); // Include thông tin về category
        }
        //Phương thức tìm tour theo id
        public async Task<Review> GetByIdAsync(int id)
        {
            return await _context.Reviews.FindAsync(id);

            //// lấy thông tin kèm theo category
            //return await _context.Tours.Include(p =>
            //p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }
        //Phương thức cập nhật review
        public async Task UpdateAsync(Review review)
        {
            _context.Reviews.Update(review);
            await _context.SaveChangesAsync();
        }
        //Phương thức tìm kiếm tour theo tên 
        public async Task<IEnumerable<Review>> GetByNameAsync(int SearchId)
        {
            //return await _context.Tours.Include(x => x.Category).Where(n => n.Name.Contains(SearchString)).ToListAsync();
            return await _context.Reviews.Where(n => n.Id == SearchId).ToListAsync();
        }
    }
}

using BookingTour.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingTour.Repositories
{
    public class EFTourRepository : ITourRepository
    {
        private readonly ApplicationDbContext _context;
        public EFTourRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //Phương thức thêm tour
        public async Task AddAsync(Tour tour)
        {
            _context.Tours.Add(tour);
            await _context.SaveChangesAsync();
        }
        //Phương thức xoá tour
        public async Task DeleteAsync(int id)
        {
            var tour = await _context.Tours.FindAsync(id);
            _context.Tours.Remove(tour);
            await _context.SaveChangesAsync();
        }
        //Phương thức lấy ra tất cả tour
        public async Task<IEnumerable<Tour>> GetAllAsync()
        {
            //return await _context.Tours.ToListAsync();
            return await _context.Tours.Include(p => p.Place).ToListAsync(); //Include thông tin về place
            //return await _context.Tours.Include(p => p.Category).ToListAsync(); // Include thông tin về category
        }
        //Phương thức tìm tour theo id
        public async Task<Tour> GetByIdAsync(int id)
        {
            return await _context.Tours.FindAsync(id);

            //// lấy thông tin kèm theo category
            //return await _context.Tours.Include(p =>
            //p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }
        //Phương thức cập nhật tour
        public async Task UpdateAsync(Tour tour)
        {
            _context.Tours.Update(tour);
            await _context.SaveChangesAsync();
        }
        //Phương thức tìm kiếm tour theo tên 
        public async Task<IEnumerable<Tour>> GetByNameAsync(string SearchString)
        {
            //return await _context.Tours.Include(x => x.Category).Where(n => n.Name.Contains(SearchString)).ToListAsync();
            return await _context.Tours.Include(x => x.Place).Where(n => n.Name.Contains(SearchString)).ToListAsync();
        }
        //Phương thức sắp xếp Tour
        public async Task<IEnumerable<Tour>> GetSortedAsync(string sortTour)
        {
            IQueryable<Tour> tours = _context.Tours;

            switch (sortTour)
            {
                case "name_desc":
                    tours = tours.OrderByDescending(t => t.Name);
                    break;
                //case "date_asc":
                //    tours = tours.OrderBy(t => t.Date);
                //    break;
                //case "date_desc":
                //    tours = tours.OrderByDescending(t => t.Date);
                //    break;
                ////Thêm các trường hợp khác tại đây
                //case "price_asc":
                //    tours = tours.OrderBy(t => t.Price);
                //    break;
                //case "price_desc":
                //    tours = tours.OrderByDescending(t => t.Price);
                //    break;
                default:
                    tours = tours.OrderBy(t => t.Name); // Sắp xếp theo tên tăng dần làm mặc định
                    break;
            }

            return await tours.ToListAsync();
        }
    }
}

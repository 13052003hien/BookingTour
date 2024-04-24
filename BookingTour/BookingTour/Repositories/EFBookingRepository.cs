using BookingTour.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingTour.Repositories
{
    public class EFBookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;
        public EFBookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //Phương thức thêm booking
        public async Task AddAsync(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
        }
        //Phương thức xoá booking
        public async Task DeleteAsync(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
        //Phương thức lấy ra tất cả booking
        public async Task<IEnumerable<Booking>> GetAllAsync()
        {
            return await _context.Bookings.ToListAsync();
            //return await _context.Tours.Include(p => p.Category).ToListAsync(); // Include thông tin về category
        }
        //Phương thức tìm booking theo id
        public async Task<Booking> GetByIdAsync(int id)
        {
            return await _context.Bookings.FindAsync(id);

            //// lấy thông tin kèm theo category
            //return await _context.Tours.Include(p =>
            //p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }
        //Phương thức cập nhật booking
        public async Task UpdateAsync(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }
        //Phương thức tìm kiếm booking theo Id
        public async Task<IEnumerable<Booking>> GetByNameAsync(int SearchId)
        {
            //return await _context.Tours.Include(x => x.Category).Where(n => n.Name.Contains(SearchString)).ToListAsync();
            return await _context.Bookings.Where(n => n.Id == SearchId).ToListAsync();
        }
        //Phương thức sắp xếp Boking(Chưa có ideas rõ để đây mẫu :>>)
        //public async Task<IEnumerable<Tour>> GetSortedAsync(string sortTour)
        //{
        //    IQueryable<Tour> tours = _context.Tours;

        //    switch (sortTour)
        //    {
        //        case "name_desc":
        //            tours = tours.OrderByDescending(t => t.Name);
        //            break;
        //        //case "date_asc":
        //        //    tours = tours.OrderBy(t => t.Date);
        //        //    break;
        //        //case "date_desc":
        //        //    tours = tours.OrderByDescending(t => t.Date);
        //        //    break;
        //        ////Thêm các trường hợp khác tại đây
        //        //case "price_asc":
        //        //    tours = tours.OrderBy(t => t.Price);
        //        //    break;
        //        //case "price_desc":
        //        //    tours = tours.OrderByDescending(t => t.Price);
        //        //    break;
        //        default:
        //            tours = tours.OrderBy(t => t.Name); // Sắp xếp theo tên tăng dần làm mặc định
        //            break;
        //    }

        //    return await tours.ToListAsync();
        //}
    }
}

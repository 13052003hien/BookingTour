using BookingTour.Models;
using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
    options) : base(options)
    {
    }
    public DbSet<Tour> Tours { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Transport> Transports { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<TourImage> TourImages { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tour>()
            .Property(t => t.ChildPrice)
            .HasPrecision(18, 2); // Số nguyên 18 là tổng số chữ số, và số 2 là số chữ số sau dấu phẩy
        modelBuilder.Entity<Tour>()
            .Property(t => t.AdultPrice)
            .HasPrecision(18, 2); // Số nguyên 18 là tổng số chữ số, và số 2 là số chữ số sau dấu phẩy
        modelBuilder.Entity<Promotion>()
            .Property(t => t.PercentPrice)
            .HasPrecision(18, 2); // Số nguyên 18 là tổng số chữ số, và số 2 là số chữ số sau dấu phẩy
    }
}
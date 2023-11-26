using ApartmentDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApartmentApplication;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }

    public DbSet<Appartment> Appartments { get; set; }
}

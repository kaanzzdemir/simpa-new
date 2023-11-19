using Microsoft.EntityFrameworkCore;
using SimPlastik.Models.Entity;

namespace SimPlastik.Models.Context
{
    public class SimpaDbContext : DbContext
    {
        public SimpaDbContext(DbContextOptions<SimpaDbContext> options):base(options) { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<TopCategory> TopCategory { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}

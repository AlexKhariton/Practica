using Microsoft.EntityFrameworkCore;
using practic.Data.Models;

namespace practic.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Realtor> Realtor { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}

using libreria_LGLA.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace libreria_LGLA.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}

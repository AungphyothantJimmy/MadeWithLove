using Microsoft.EntityFrameworkCore;

namespace MadeWithLove.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}

using chat.Models;
using Microsoft.EntityFrameworkCore;

namespace chat.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserDetails> users => Set<UserDetails>();
    }
}

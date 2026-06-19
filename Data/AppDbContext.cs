using chat.Entity;
using Microsoft.EntityFrameworkCore;

namespace chat.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserDetails> users => Set<UserDetails>();

        public DbSet<Message> messages => Set<Message>();
    }
}

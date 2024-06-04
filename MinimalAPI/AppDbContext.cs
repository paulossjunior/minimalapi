using Microsoft.EntityFrameworkCore;

namespace MinimalAPI
{
    class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}

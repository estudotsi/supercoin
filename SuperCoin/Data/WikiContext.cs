using Microsoft.EntityFrameworkCore;
using Wiki.Models;
using Wiki.Models.Usuario;

namespace Wiki.Data
{
    public class WikiContext : DbContext
    {
        public WikiContext(DbContextOptions<WikiContext> opts) : base(opts) { }

        public DbSet<UserModel> Usuario { get; set; }
        public DbSet<Task> Tasks { get;}
    }
}

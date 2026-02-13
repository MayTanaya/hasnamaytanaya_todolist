using Microsoft.EntityFrameworkCore;
using hasnamaytanaya_todolist.Models;

namespace hasnamaytanaya_todolist.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Todo> Todos { get; set; }
    }
}
using PDPbaithi2324.Models;
using Microsoft.EntityFrameworkCore;

namespace PDPbaithi2324.Data
{
    public class ApplicationDbContext : DbContext
    { 
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Person> Person { get; set; }
    }
}    
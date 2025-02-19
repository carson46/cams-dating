using Microsoft.EntityFrameworkCore;

namespace Mission6.Models;

public class DatingApplicationContext : DbContext
{
    public DatingApplicationContext(DbContextOptions<DatingApplicationContext> options) : base(options)
    {
        
    }
    
    public DbSet<Application> Applications { get; set; }
    
}


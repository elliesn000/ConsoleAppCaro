using Classes;
using DbClasses;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{    
    public DbSet<User> Users { get; set; }
    public DbSet<Game> Boards { get; set; }
    public DbSet<Piece> Pieces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CaroAppDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
    }
    
}
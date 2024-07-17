using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieShopApp.Core.Entities;
namespace MovieShopApp.Infrastructure.Data;

public class MovieShopEfDbContext: DbContext
{
    public MovieShopEfDbContext(DbContextOptions<MovieShopEfDbContext> options) : base(options)
    {
        
    }
   
    public DbSet<Genres> Genres { get; set; }
    public DbSet<Casts> Casts { get; set; }
    public DbSet<Movies> Movies { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Roles> Roles { get; set; }
    
    public DbSet<MovieGenres> MovieGenres { get; set; }
    public DbSet<MovieCasts> MovieCasts { get; set; }
    public DbSet<Trailers> Trailers { get; set; }
    public DbSet<Favorites> Favorites { get; set; }
    public DbSet<Reviews> Reviews { get; set; }
    public DbSet<Purchases> Purchases { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     var conn = new ConfigurationBuilder().AddJsonFile("appsettings.json")
    //         .Build().GetConnectionString("MovieShopEfDb");
    //
    //     optionsBuilder.UseSqlServer(conn);
    // }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Favorites>()
            .HasNoKey();
        modelBuilder.Entity<MovieCasts>()
            .HasNoKey();
        modelBuilder.Entity<MovieGenres>()
            .HasNoKey();
        modelBuilder.Entity<Purchases>()
            .HasNoKey();
        modelBuilder.Entity<Reviews>()
            .HasNoKey();
        modelBuilder.Entity<UserRoles>()
            .HasNoKey();


        base.OnModelCreating(modelBuilder);
    }

}
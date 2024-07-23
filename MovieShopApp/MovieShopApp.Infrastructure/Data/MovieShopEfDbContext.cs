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
    
   protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
       
            modelBuilder.Entity<MovieGenres>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId });

            modelBuilder.Entity<MovieGenres>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mg => mg.MovieId);

            modelBuilder.Entity<MovieGenres>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.MovieGenres)
                .HasForeignKey(mg => mg.GenreId);
       
            modelBuilder.Entity<MovieCasts>()
                .HasKey(mc => new { mc.MovieId, mc.CastId });

            modelBuilder.Entity<MovieCasts>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.MovieCasts)
                .HasForeignKey(mc => mc.MovieId);

            modelBuilder.Entity<MovieCasts>()
                .HasOne(mc => mc.Cast)
                .WithMany(c => c.MovieCasts)
                .HasForeignKey(mc => mc.CastId);

            modelBuilder.Entity<Favorites>()
                .HasKey(f => new { f.MovieId, f.UserId });

            modelBuilder.Entity<Favorites>()
                .HasOne(f => f.Movie)
                .WithMany(m => m.Favorites)
                .HasForeignKey(f => f.MovieId);
       
            modelBuilder.Entity<Reviews>()
                .HasKey(r => new { r.MovieId, r.UserId });

            modelBuilder.Entity<Reviews>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MovieId);

            modelBuilder.Entity<Purchases>()
                .HasKey(p => new { p.MovieId, p.UserId });

            modelBuilder.Entity<Purchases>()
                .HasOne(p => p.Movie)
                .WithMany(m => m.Purchases)
                .HasForeignKey(p => p.MovieId);
            
            modelBuilder.Entity<UserRoles>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

        }

}
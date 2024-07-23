using ApplicationCore.Models;
using Microsoft.EntityFrameworkCore;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Entities;
using MovieShopApp.Infrastructure.Data;

namespace MovieShopApp.Infrastructure.Repositories
{
    public class MovieRepository : BaseRepository<Movies>, IMovieRepository
    {
        public MovieRepository(MovieShopEfDbContext movieShopEfDbContext) : base(movieShopEfDbContext)
        {
        }

       
        public override Movies GetById(int id)
        {
            return movieShopEfDbContext.Movies
                .Include(m => m.MovieCasts)
                .ThenInclude(mc => mc.Cast)
                .Include(m => m.Trailers)
                .FirstOrDefault(m => m.Id == id);
        }

        public async Task<IEnumerable<Movies>> GetHighestGrossingMovies() {
            return await movieShopEfDbContext.Movies
                .OrderByDescending(m => m.Revenue)
                .Take(10)
                .ToListAsync();
        }

        public async Task<Movies> GetMovieByIdAsync(int id) {
            return await movieShopEfDbContext.Movies
                .Include(m => m.MovieGenres)
                .ThenInclude(mg => mg.Genre)
                .Include(m => m.MovieCasts)
                .ThenInclude(mc => mc.Cast)
                .Include(m => m.Trailers)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Movies> GetMovieDetailsAsync(int id) {
            return await movieShopEfDbContext.Movies
                .Include(m => m.MovieGenres)
                .ThenInclude(mg => mg.Genre)
                .Include(m => m.MovieCasts)
                .ThenInclude(mc => mc.Cast)
                .Include(m => m.Trailers)
                .Include(m => m.Reviews)
                .AsSplitQuery()
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        
        public async Task<PaginationMovieModel<Movies>> GetMoviesByGenreAsync(int genreId, int pageSize, int pageNumber) {
            var totalMovies = await movieShopEfDbContext.Movies.CountAsync(m => m.MovieGenres.Any(g => g.GenreId == genreId));
            var movies = await  movieShopEfDbContext.Movies
                .Where(m => m.MovieGenres.Any(g => g.GenreId == genreId))
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PaginationMovieModel<Movies>(movies, pageNumber, pageSize, totalMovies);
        }
    }
}
using ApplicationCore.Models;
using MovieShopApp.Core.Entities;

namespace MovieShopApp.Core.Contracts.Repositories;

public interface IMovieRepository : IRepository<Movies>
{
    Task<IEnumerable<Movies>> GetHighestGrossingMovies();

    Task<Movies> GetMovieByIdAsync(int id);

    Task<Movies> GetMovieDetailsAsync(int id);

    Task<PaginationMovieModel<Movies>> GetMoviesByGenreAsync(int genreId, int pageSize, int pageNumber);
}
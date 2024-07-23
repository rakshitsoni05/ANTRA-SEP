using ApplicationCore.Models;
using MovieShopApp.Core.Entities;
using MovieShopApp.Core.Model.Request;
using MovieShopApp.Core.Model.Response;

namespace MovieShopApp.Core.Contracts.Services;

public interface IMovieService
{
    int AddMovie(MovieRequestModel movieRequestModel);
    int UpdateMovie(MovieRequestModel movieRequestModel, int id);

    int DeleteMovie(int id);
    IEnumerable<MovieResponseModel> GetAllMovies();
    MovieResponseModel GetMovieById(int id);
    
    
    Task<Movies> GetMovieDetailsAsync(int id);

    Task<PaginationMovieModel<Movies>> GetMoviesByGenreAsync(int genreId, int pageSize, int pageNumber);

}
using ApplicationCore.Models;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Entities;
using MovieShopApp.Core.Model.Request;
using MovieShopApp.Core.Model.Response;

namespace MovieShopApp.Infrastructure.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository movieRepository;
    
    public MovieService(IMovieRepository movieRepository, ICastRepository castRepository)
    {
        this.movieRepository = movieRepository;
      
    }
    public int AddMovie(MovieRequestModel movieRequestModel)
    {
        Movies movie = new Movies();
        movie.Title = movieRequestModel.Title;
        movie.Tagline = movieRequestModel.Tagline;
        movie.BackDropUrl = movieRequestModel.BackDropUrl;
        return movieRepository.Insert(movie);
    }

    public int UpdateMovie(MovieRequestModel movieRequestModel, int id)
    {
        Movies movie = new Movies();
        movie.Title = movieRequestModel.Title;
        movie.Tagline = movieRequestModel.Tagline;
        movie.BackDropUrl = movieRequestModel.BackDropUrl;
        movie.Id = id;
        return movieRepository.Update(movie);
    }

    public int DeleteMovie(int id)
    {
        return movieRepository.Delete(id);
    }

    public IEnumerable<MovieResponseModel> GetAllMovies()
    {
        var movies = movieRepository.GetAll();

        return movies.Select(movie => new MovieResponseModel
        {
            Id = movie.Id,
            Title = movie.Title,
            Tagline = movie.Tagline,
            ImdbUrl = movie.ImdbUrl,
            BackDropUrl = movie.BackDropUrl,
            Overview = movie.Overview,
           
        }).ToList();
    }

    public MovieResponseModel GetMovieById(int id)
    {
        var movie = movieRepository.GetById(id);
        if (movie == null) return null;

        var movieResponse = new MovieResponseModel
        {
            Id = movie.Id,
            Title = movie.Title,
            Tagline = movie.Tagline,
            ImdbUrl = movie.ImdbUrl,
            BackDropUrl = movie.BackDropUrl,
            Overview = movie.Overview,
            PosterUrl = movie.PosterUrl,
            Revenue = movie.Revenue,
            ReleaseDate = movie.ReleaseDate,
            Budget = movie.Budget,
            OriginalLanguage = movie.OriginalLanguage,
            Runtime = movie.Runtime,
            Casts = movie.MovieCasts?.Select(mc => new CastResponseModel
            {
                Id = mc.Cast.Id,
                Name = mc.Cast.Name,
                ProfilePath = mc.Cast.ProfilePath
            }).ToList() ?? new List<CastResponseModel>(),
            Trailers = movie.Trailers.Select(t => new TrailerResponseModel
            {
                Name = t.Name,
                TrailerUrl = t.TrailerUrl
            }).ToList()
            
        };

        return movieResponse;
    }

    public async Task<Movies> GetMovieDetailsAsync(int id)
    {
        return await movieRepository.GetMovieDetailsAsync(id);
    }

    public async Task<PaginationMovieModel<Movies>> GetMoviesByGenreAsync(int genreId, int pageSize, int pageNumber) {
        return await movieRepository.GetMoviesByGenreAsync(genreId, pageSize, pageNumber);
    }
}

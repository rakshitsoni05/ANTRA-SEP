using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Infrastructure.Services;

namespace MovieShopMVC.Controllers;

public class MoviesController : Controller
{
    private readonly IMovieService movieService;
    private readonly IGenreService _genreService;

    public MoviesController(IMovieService movieService, IGenreService genreService)
    {
        this.movieService = movieService;
        this._genreService = genreService;
    }

    public IActionResult Index()
    {
        var movies = movieService.GetAllMovies();
        return View(movies);
    }
    
    public async Task<IActionResult> Details(int id) {
        var movie = await movieService.GetMovieDetailsAsync(id);
        if (movie == null) {
            return NotFound();
        }
        return View(movie);
    }
    
    public async Task<IActionResult> MoviesByGenre(int id, int pageSize = 50, int pageNumber = 1) {
        var movies = await movieService.GetMoviesByGenreAsync(id, pageSize, pageNumber);
        var genre = await _genreService.GetGenreByIdAsync(id);
        ViewData["GenreId"] = id;
        ViewData["GenreName"] = genre?.Name;
        return View(movies);
    }
    
   
}
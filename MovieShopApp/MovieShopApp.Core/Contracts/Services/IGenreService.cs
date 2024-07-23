using MovieShopApp.Core.Entities;

namespace MovieShopApp.Core.Contracts.Services;

public interface IGenreService
{
    Task<IEnumerable<Genres>> GetAllGenresAsync();
    Task<Genres> GetGenreByIdAsync(int id);
    
    
}
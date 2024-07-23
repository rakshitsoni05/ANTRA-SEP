using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Entities;

namespace MovieShopApp.Infrastructure.Services;

public class GenreService : IGenreService {

    private readonly IGenreRepository _genreRepository;

    public GenreService(IGenreRepository genreRepository) {
        _genreRepository = genreRepository;
    }

    public async Task<IEnumerable<Genres>> GetAllGenresAsync() {
        return await _genreRepository.GetAllAsync();
    }

    public async Task<Genres> GetGenreByIdAsync(int id) {
        return await _genreRepository.GetByIdAsync(id);
    }
    
}
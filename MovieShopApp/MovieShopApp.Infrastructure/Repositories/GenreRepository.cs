using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Entities;
using MovieShopApp.Infrastructure.Data;

namespace MovieShopApp.Infrastructure.Repositories;

public class GenreRepository : BaseRepository<Genres>, IGenreRepository {

    private readonly MovieShopEfDbContext _dbContext;

    public GenreRepository(MovieShopEfDbContext dbContext) : base(dbContext) {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

}
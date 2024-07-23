using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Entities;
using MovieShopApp.Infrastructure.Data;

namespace MovieShopApp.Infrastructure.Repositories;

public class CastRepository :BaseRepository<Casts>, ICastRepository
{
    public CastRepository(MovieShopEfDbContext movieShopEfDbContext) : base(movieShopEfDbContext)
    {
    }
    
}
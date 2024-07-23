using MovieShopApp.Core.Entities;

namespace MovieShopApp.Core.Contracts.Services;

public interface ICastService
{
    Task<Casts> GetCastDetailsAsync(int id);
}
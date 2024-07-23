using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Entities;

namespace MovieShopApp.Infrastructure.Services;

public class CastService : ICastService
{
    private readonly ICastRepository _castRepository;

    public CastService(ICastRepository castRepository) {
        _castRepository = castRepository;
    }

    public async Task<Casts> GetCastDetailsAsync(int id) {
        return await _castRepository.GetByIdAsync(id);
    }
}
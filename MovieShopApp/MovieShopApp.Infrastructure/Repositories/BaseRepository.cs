using Microsoft.EntityFrameworkCore;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Infrastructure.Data;

namespace MovieShopApp.Infrastructure.Repositories;

public class BaseRepository<T> : IRepository<T> where T : class
{
    public readonly MovieShopEfDbContext movieShopEfDbContext;
    
    public BaseRepository(MovieShopEfDbContext movieShopEfDbContext)
    {
        this.movieShopEfDbContext = movieShopEfDbContext;
    }

    public virtual async Task<T> GetByIdAsync(int id) {
        return await movieShopEfDbContext.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync() {
        return await movieShopEfDbContext.Set<T>().ToListAsync();
    }

    public int Insert(T entity)
    {
        movieShopEfDbContext.Set<T>().Add(entity);
        return movieShopEfDbContext.SaveChanges();
    }

    public int Update(T entity)
    {
        movieShopEfDbContext.Set<T>().Entry(entity).State = EntityState.Modified;
        return movieShopEfDbContext.SaveChanges();
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            movieShopEfDbContext.Set<T>().Remove(entity);
            movieShopEfDbContext.SaveChanges();
            return 1;
        }

        return 0;
    }

    public virtual T GetById(int id)
    {
        return movieShopEfDbContext.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
         return movieShopEfDbContext.Set<T>().ToList();
       
    }
}
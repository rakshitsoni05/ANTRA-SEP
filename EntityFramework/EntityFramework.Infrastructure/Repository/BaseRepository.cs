using EntityFramework.Core.Interfaces;
using EntityFramework.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Infrastructure.Repository;

public class BaseRepository<T>: IRepository<T> where  T: class
{
    private EfDemoDbContext _demoDbContext = new EfDemoDbContext();
    public int Insert(T obj)
    {
        _demoDbContext.Set<T>().Add(obj);
        return _demoDbContext.SaveChanges();
    }

    public int DeleteById(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            _demoDbContext.Set<T>().Remove(entity);
            return _demoDbContext.SaveChanges();
        }

        return 0;
    }

    public int Update(T obj)
    {
        _demoDbContext.Entry(obj).State = EntityState.Modified;
        return _demoDbContext.SaveChanges();
    }

    public T GetById(int id)
    {
        return _demoDbContext.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _demoDbContext.Set<T>().ToList();
    }
}
namespace MovieShopApp.Core.Contracts.Repositories;

public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
   
    int Insert(T entity);
    int Update(T entity);
    int Delete(int id);
    T GetById(int id);
    IEnumerable<T> GetAll();

}
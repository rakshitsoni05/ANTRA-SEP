using System;

using ConsoleApp4.DataModel;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> _items;

    public GenericRepository()
    {
        _items = new List<T>();
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Changes saved to the database.");
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public T GetById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }
}

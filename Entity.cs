using System;
using System.Collections.Generic;
using System.Linq;
public class Entity
{
    public int Id { get; set; }
}
public interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}
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
        Console.WriteLine("Changes saved.");
    }
    public IEnumerable<T> GetAll()
    {
        return _items;
    }
    public T GetById(int id)
    {
        return _items.FirstOrDefault(x => x.Id == id);
    }
}

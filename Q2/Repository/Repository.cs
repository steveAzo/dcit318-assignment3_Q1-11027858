using System;

public class Repository<T>
{
    private readonly List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);
    public List<T> GetAll() => new List<T>(items);

    public T? GetById(Func<T, bool> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
                return item;
        }
        return default;
    }

    public bool Remove(Func<T, bool> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
                return items.Remove(item);
        }
        return false;
    }
    
}
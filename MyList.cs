public class MyList<T>
{
    private List<T> _list;

    public MyList()
    {
        _list = new List<T>();
    }
    public void Add(T element)
    {
        _list.Add(element);
    }
    public T Remove(int index)
    {
        if (index < 0 || index >= _list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        T removedElement = _list[index];
        _list.RemoveAt(index);
        return removedElement;
    }
    public bool Contains(T element)
    {
        return _list.Contains(element);
    }
    public void Clear()
    {
        _list.Clear();
    }
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        _list.Insert(index, element);
    }
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= _list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        _list.RemoveAt(index);
    }
    public T Find(int index)
    {
        if (index < 0 || index >= _list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        return _list[index];
    }
}

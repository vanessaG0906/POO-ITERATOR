public class Playlist<T> : ICollection<T>
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new Iterator<T>(_items);
    }

    public IIterator<T> CreateReverseIterator()
    {
        return new Iterator<T>(_items, true);
    }
}

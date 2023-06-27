public class Iterator<T> : IIterator<T>
{
    private List<T> _collection;
    private int _position = 0;
    private bool _reverse = false;

    public Iterator(List<T> collection, bool reverse = false)
    {
        _collection = collection;
        _reverse = reverse;
        if (reverse)
        {
            _position = _collection.Count - 1;
        }
    }

    public bool HasNext()
    {
        if (_reverse)
        {
            return _position >= 0;
        }
        return _position < _collection.Count;
    }

    public T Next()
    {
        T item = _collection[_position];
        if (_reverse)
        {
            _position--;
        }
        else
        {
            _position++;
        }
        return item;
    }
}

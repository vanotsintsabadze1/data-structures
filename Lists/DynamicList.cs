using System.Collections;

namespace Practice.Lists;

class DynamicList<T> : IEnumerable<T>
{
    private int _size;
    private T[] _items;
    private int defaultCapacity = 4;

    public DynamicList()
    {
        _items = new T[defaultCapacity];
        _size = 0;
    }

    public DynamicList(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentOutOfRangeException("Size can't be equal or less than 0!");
        }
        _items = new T[size];
        _size = 0;
    }

    public int Count { get { return _size; } }

    public T this[int idx]
    {
        get => _items[idx];
        set => _items[idx] = value;
    }

    public void Add(T item)
    {
        if (_size == _items.Length)
        {
            ResizeArray();
        }

        _items[_size++] = item;
    }

    public void GetAll()
    {
        for (int i = 0; i < _size; i++)
        {
            if (i == _size - 1)
            {
                Console.Write($"{_items[i]}");
            }
            else
            {
                Console.Write($"{_items[i]} ");
            }
        }
        Console.WriteLine();
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _size; i++)
        {
            yield return _items[i];
        }
    }

    public void Remove(T item)
    {
        int idx = Array.IndexOf(_items, item);

        if (idx != -1)
        {
            RemoveAt(idx);
        }
        else
        {
            throw new ArgumentException("Such element does not exist");
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _size)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        for (int i = index; i < _size - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        _size--;

    }

    private void ResizeArray()
    {
        int newCapacity = _items.Length * 2;
        T[] newArr = new T[newCapacity];
        Array.Copy(_items, newArr, _size);
        _items = newArr;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


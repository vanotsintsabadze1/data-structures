namespace Practice.Stack;

class CustomStack<T>
{
    private int _pointer = 0;
    private T[] _arr;
    private int _defaultCapacity = 16;
    public int Size => _pointer;

    public CustomStack()
    {
        _arr = new T[_defaultCapacity];
    }


    public CustomStack(int size)
    {
        _arr = new T[size];
    }

    public void Add(T item)
    {
        if (_pointer == _arr.Length )
        {
            ResizeArray();
        }
        _arr[_pointer] = item;
        _pointer++;
    }

    public void GetAll()
    {
        Console.WriteLine($"pointer is at - {_pointer}");
        for (int i = 0; i < _pointer; i++)
        {
            Console.Write($"{_arr[i]} ");
        }
    }

    public void Remove()
    {
        if (_pointer == 0)
        {
            throw new ArgumentOutOfRangeException("Stack is empty");
        }

        _arr[_pointer - 1] = default!;
        _pointer--;
 }

    public T Peek()
    {
        return _arr[_pointer - 1];
    }

    public bool isEmpty()
    {
        return _pointer == 0;
    }

    private void ResizeArray()
    {
        int newCapacity = _arr.Length * 2;
        T[] newArr = new T[newCapacity];
        Array.Copy(_arr, newArr, _pointer);
        _arr = newArr;
    }
}

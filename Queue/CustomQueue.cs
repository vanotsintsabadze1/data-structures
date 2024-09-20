// I didn't make this queue resizable, therefore the queue has a limited size. The default size without providing it into a constructor is 10, otherwise it's the one you want it to be

namespace Practice.Queue;

class CustomQueue<T>
{
    private T[] _items;
    private int left = 0;
    private int right = 0;

    public int Left => left;
    public int Right => right;


    public CustomQueue()
    {
        _items = new T[10];
    }

    public CustomQueue(int size)
    {
        if (size == 0)
        {
            throw new InvalidCastException("Size cannot be 0");

        }

        _items = new T[size];
    }

    public void GetAll()
    {
        if (left == right)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        if (left < right)
        {
            for (int i = left; i < right; i++)
            {
                 Console.Write(_items[i]); 
            }
        } else
        {
            for (int i = 0; i < _items.Length; i++)
            {
                Console.Write($"{_items[i]} ");
            }
        }
    }

    public void Enqueue(T item)
    {
        if (right + 1 == left)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        _items[right] = item;
        right++;
        if (right == _items.Length)
        {
            right = 0;
        }

    }

    public void Dequeue()
    {
        if (right == left) // right and left are on the same indexes if and only if the queue is empty        
        {
            throw new InvalidOperationException("Queue is empty");
        }

        _items[left] = default!;
        left++;

        if (left == _items.Length)
        {
            left = 0;
        }
    }



}

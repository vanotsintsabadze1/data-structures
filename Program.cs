using Practice.Queue;
namespace Practice;

class Program
{ 
    public static void Main()
    {
        CustomQueue<int> q = new();

        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);
        q.Enqueue(5);
        q.GetAll();
        Console.WriteLine($"\nleft - {q.Left}");
        Console.WriteLine($"right - {q.Right}");
        q.Dequeue();
        q.Enqueue(6);
        q.Dequeue();
        q.Enqueue(7);
        q.Dequeue();
        q.Enqueue(8);
        q.Dequeue();
        q.Enqueue(9);
        q.GetAll();
        Console.WriteLine($"\nleft - {q.Left}");
        Console.WriteLine($"right - {q.Right}");
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);
        q.Enqueue(5);
        q.GetAll();
        Console.WriteLine($"\nright - {q.Right}");

    }
}

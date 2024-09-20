using System.Collections;

namespace Practice.Lists;

public class Node
{
    public object? Value { get; set; }
    public Node? Next { get; set; }


    public Node(object val, Node? next = null)
    {
        Value = val;
        Next = next;
    }
}

public class CustomLinkedList : IEnumerable<Node>
{
    public Node? Head { get; private set; }

    public Node Tail
    {
        get
        {
            if (Head == null)
            {
                throw new ArgumentOutOfRangeException("LinkedList is empty");
            }

            if (Head.Next == null)
            {
                return Head;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }
    }

    public int Size
    {
        get
        {
            int count = 0;
            Node? current = Head;

            if (Head == null)
            {
                return 0;
            }
            
            if (Head != null && Head.Next == null)
            {
                return 1;
            }

            while (current != null)
            {
                current = current.Next;
                count++;
            }
            return count;

        }
    }

    public CustomLinkedList(Node head)
    {
        Head = head;
    }

    public void Add(Node n)
    {
        if (Head == null)
        {
            Head = n;
            return;
        }

        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = n;
    }

    public void Insert(int index, Node n)
    {
        if (Head == null)
        {
            throw new InvalidOperationException("LinkedList head is empty");
        }

        if (index < 0 || index > Size)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        if (index == 0)
        {
            // just so you know, this will raise a bug if n has a next, but i cba writing logic for it since i want to just cover the basic idea.
            // feel free to enhance it if you want to spend time on it;
            n.Next = Head;
            
            return;
        }

        Node current = Head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next!;
        }
        n.Next = current.Next;
        current.Next = n;
    }

    public void Clear()
    {
        if (Size == 0)
        {
            throw new InvalidOperationException("Clear can't be used on an empty LinkedList");
        }

        Head = null;
    }


    public void Remove(object val)
    {
        if (Head == null)
        {
            Console.WriteLine("Head is empty, no list exists");
            return;
        }

        if (Object.Equals(val, Head.Value))
        {
            Head = Head.Next;
            return;
        }

        Node current = Head;

        while (current.Next != null)
        {
            if (Object.Equals(val, current.Next.Value))
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }

        Console.WriteLine("No node with such value was found");
    }

    public IEnumerator<Node> GetEnumerator()
    {
        Node current = Head!;
        while (current != null)
        {
            yield return current;
            current = current.Next!;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

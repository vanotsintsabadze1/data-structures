using Practice.Lists;
namespace Practice;

class Program
{ 
    public static void PrintValues(CustomLinkedList cll)
    {
        foreach (Node n in cll)
        {
            Console.Write(n.Value + " ");
        }
    }

    public static void Main()
    {
        Node nodeOne = new(1);
        Node nodeTwo = new(1, nodeOne);
        CustomLinkedList cll = new(nodeTwo);

        cll.Add(new Node(2));

        Console.WriteLine("Something " + cll.Size);

        Node nodeThree = new(4);

        //cll.Insert(2, nodeThree);
        PrintValues(cll);
        Console.WriteLine();

    }
}

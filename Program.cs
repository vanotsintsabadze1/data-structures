using Practice.Stack;
namespace Practice;

class Program
{ 
    public static void Main()
    {
        CustomStack<int> cs = new();

        cs.Add(22);
        cs.Add(10);
        cs.Add(4);
        cs.Add(8);
        cs.Peek();
        cs.GetAll();
        cs.Remove();
        Console.WriteLine();
        cs.GetAll();
        bool isEmp = cs.isEmpty();
        Console.WriteLine($"\nIs the Stack Empty? - {isEmp}");

    }
}

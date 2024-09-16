using Practice.Lists;

namespace Practice;

class Program
{ 
    public static void Main()
    {
        DynamicList<int> dArr = new();

        dArr.Add(6);
        dArr.Add(2);
        dArr.Add(3);
        dArr.Add(4);
        dArr.GetAll();
        dArr.Remove(2);
        dArr.GetAll();
        dArr.RemoveAt(dArr.Count - 1);

        foreach(int i in dArr)
        {
            Console.Write(i);
        }
    }
}

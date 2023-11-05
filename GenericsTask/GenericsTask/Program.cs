using CustomCollectionsGeneric;
using System.Reflection;

namespace GenericsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> ints = new CustomList<int>(1, 2, 3);
            Console.WriteLine(ints.Capacity);
            Console.WriteLine(ints.Count);
            ints.Add(4);
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);
            ints.Add(4);
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);
            ints.Add(6);
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);
            ints.Add(7);
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);//12
            ints.Clear();
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);
            ints.Add(1);
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);
            ints.Add(1);
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);
            Console.WriteLine(ints.IndexOf(1));
            ints.Add(2);
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Capacity);
            ints.Reverse();
            Console.WriteLine(ints[0]);//2
        }
    }
}
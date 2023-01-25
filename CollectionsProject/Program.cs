global using System.Collections; 
namespace CollectionsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            //pushing values into stack
            s.Push(10);
            s.Push(true);
            s.Push(25.57);
            s.Push("Dharmendra");
            s.Push('A');
            foreach(object obj in s)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("\n");
           // popping the values from the stack
            s.Pop();
            foreach (object obj in s)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("\n");
            // finding the top element of the stack
            Console.WriteLine(s.Peek());
            Console.WriteLine("\n");
            // after peek elements of statck not deleted
            foreach (object obj in s)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine(s.Count);
            Console.WriteLine("\n");
            s.Push("Raju");
            Console.WriteLine(s.Count);
            Console.WriteLine("\n");
            s.Clear();
            Console.WriteLine(s.Count);
            Console.WriteLine("\n");

        }
    }
}
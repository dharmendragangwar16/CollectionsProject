namespace CollectionsProject
{
    internal class Class4
    {
        static void Main()
        {
            List<int> li = new List<int>(); 
            li.Add(10);  li.Add(20); li.Add(30); li.Add(40);
            for(int i=0; i<li.Count;i++)
            {
                Console.Write(li[i] + " ");
               
            }
            Console.WriteLine("\n");
            li.Insert(4,50);
            li.Insert(5, 60);
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");

            }
            Console.WriteLine("\n");
            li.Remove(10);


            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");

            }
            Console.WriteLine("\n");
            li.RemoveAt(2);
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");

            }
            Console.WriteLine("\n");
            li.RemoveRange(2, 2);
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");

            }
            Console.ReadLine();
        }
    }
}

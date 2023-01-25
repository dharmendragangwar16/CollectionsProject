namespace CollectionsProject
{
    internal class Class2
    {
        static void Main()
        {
            ArrayList coll1=new ArrayList();
            Console.WriteLine("Initial Capacity : "+ coll1.Capacity);
            coll1.Add(100);
            Console.WriteLine("Initial Capacity after inserting 1st item : " + coll1.Capacity);
            coll1.Add("Hello World");
            coll1.Add(true);
            coll1.Add(25.45);
            coll1.Add(false);
            Console.WriteLine("Initial Capacity after inserting 1st item : " + coll1.Capacity);
            Console.WriteLine("\n");
           
            for(int i=0;i<coll1.Count;i++)
            {
                Console.WriteLine(coll1[i]+  " ");
            }
           // coll1.Remove(100);
           // coll1.Remove(true);
            Console.WriteLine("\n");
            for (int i = 0; i < coll1.Count; i++)
            {
                Console.WriteLine(coll1[i] + " ");
            }
            Console.WriteLine("\n");
            coll1.Add("Dharmendra");
            for (int i = 0; i < coll1.Count; i++)
            {
                Console.WriteLine(coll1[i] + " ");
            }
            Console.WriteLine("\n");
            coll1.RemoveAt(0);
            for (int i = 0; i < coll1.Count; i++)
            {
                Console.WriteLine(coll1[i] + " ");
            }
            coll1.RemoveRange(0,2);
            Console.WriteLine("\n");
          
            for (int i = 0; i < coll1.Count; i++)
            {
                Console.WriteLine(coll1[i] + " ");
            }



            Console.ReadLine();

        }
    }
}

namespace CollectionsProject
{
    internal class Class1
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue("Dharmendra");
            q.Enqueue(222.45);
            q.Enqueue(true);

            //foreach(object obj in q)
            //{
            //    Console.WriteLine(obj + " ");
               
            //}
            
            //Console.WriteLine( "Elements in queue :"+ q.Count);

            q.Enqueue("Sanju");
            Console.Clear();

            foreach(object obj in q)
            {
                Console.WriteLine(obj + " ");
               
            }
            Console.WriteLine( "Elements in queue :"+ q.Count);


        }

    }
}

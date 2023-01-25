namespace CollectionsProject
{
    internal class Class6
    {
        static void Main()
        {
            List<int> list1 = new List<int>() { 20,30,43,56,46,2,3,43,56,24,68,76,54,68,9,34,56,78,65,55,45,46,87};
            List<int> list2 = new List<int>();
            Console.WriteLine("origional list");

            foreach(int i in list1)
            {
                Console.Write(i +  " ");
            }
            Console.WriteLine();
            foreach(int item in list1)
            {
                if(item>40)
                {
                    list2.Add(item);
                }
            }
            list2.Sort();
            list2.Reverse();
            Console.WriteLine("descending order sorted  list :");
            foreach(int values in list2)
            {
                Console.Write(values+ " ");

            }
            Console.ReadLine();
        }
    }
}

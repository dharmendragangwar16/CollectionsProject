namespace CollectionsProject
{
    internal class Class8
    {
        static void Main()
        {
            int[] arr = { 20, 30, 24, 56, 76, 45, 87, 34, 76, 45, 98, 78, 66, 54, 45, 66, 34, 75, 74 };

            List<int> list1 = new List<int>() { 20, 30, 43, 56, 46, 2, 3, 43, 56, 24, 68, 76, 54, 68, 9, 34, 56, 78, 65, 55, 45, 46, 87 };

            var brr = from i in arr where i > 40 orderby i descending select i;
            Console.WriteLine(String.Join(", ",arr));

            var coll1 = from i in arr where i > 40 orderby i descending select i;

            Console.WriteLine(String.Join(", ",coll1));

            Console.ReadLine();
        }
    }
}

namespace CollectionsProject
{
    internal class Class7
    {
        static void Main()
        {
            int Count = 0, Index = 0;
            int[] arr = { 20, 30, 24, 56, 76, 45, 87, 34, 76, 45, 98, 78, 66, 54, 45, 66, 34, 75, 74 };
           

            foreach(int i in arr)
            {
                if (i>40)
                {
                    Count += 1;
                }
            }
            int[] brr=new int[Count];
            foreach(int i in brr)
            {
                if(i>40)
                {
                    brr[Index] = i;
                    Index += 1;

                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);

            Console.WriteLine(String.Join(", ",brr));
            Console.ReadLine();
        }
      

       


    }
}

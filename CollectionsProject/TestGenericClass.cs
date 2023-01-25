namespace CollectionsProject
{
    class Math<T>
    {
        public T Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2;
        }
        public T Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2;
        }
        public T Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 * d2;
        }
        public T Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 / d2;
        }
    }
      
        internal class TestGenericClass
    { 
                static void Main()
                {
             Math<int> m = new Math<int>();

            Console.WriteLine(m.Add(10, 10));
            Console.WriteLine(m.Sub(10, 10));
            Console.WriteLine(m.Mul(10, 10));
            Console.WriteLine(m.Div(10, 10));
            Console.WriteLine("\n");

            Math<double> m1 = new Math<double>();
            Console.WriteLine(m1.Add(10.12,9.56));
            Console.WriteLine(m1.Sub(10.12, 9.56));
            Console.WriteLine(m1.Mul(10.12, 9.56));
            Console.WriteLine(m1.Div(10.12, 9.56));

            Console.ReadLine();
                }
    }
}


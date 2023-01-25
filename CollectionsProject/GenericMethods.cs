using System.Security.Cryptography.X509Certificates;

namespace CollectionsProject
{
    internal class GenericMethods
    {
        public bool AreEqual<T>(T a,T b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            GenericMethods g = new GenericMethods();
            Console.WriteLine(g.AreEqual<int>(10, 20));
            Console.WriteLine(g.AreEqual<string>("hello","hello"));
            Console.WriteLine(g.AreEqual<double>(10.12, 10.12));
            Console.WriteLine(g.AreEqual<bool>(true,false));
        }
    }
}

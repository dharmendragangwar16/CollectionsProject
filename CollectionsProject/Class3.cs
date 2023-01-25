using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class3
    {
        static void Main()
        {
            Hashtable Emp=new Hashtable();
            Emp.Add("Emp-Id","1001");
            Emp.Add("Name","Scott");
            Emp.Add("Job","CEO");
            Emp.Add("Mgr-Id","Null");
            Emp.Add("Commison","500");

            Console.WriteLine(Emp["Name"]);
            Console.WriteLine(Emp["Job"]);
            Console.WriteLine("Commison");
            foreach(object Key in Emp.Keys)
            {
                 Console.WriteLine($"{Key}:{Emp[Key]}");
                //Console.WriteLine(Key + ":" + Emp[Key]);

            }

            Console.ReadLine();
        }
    }
}

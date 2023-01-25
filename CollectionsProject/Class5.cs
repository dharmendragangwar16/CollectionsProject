namespace CollectionsProject
{
    internal class Class5
    {
        static void Main()
        {
            Dictionary<string, object> Emp = new Dictionary<string, object>();
            Emp.Add("Empid", 1003);
            Emp.Add("Name", "Scott");
            Emp.Add("Job", "Manager");
            Emp.Add("Salary", 50000.20);
            Emp.Add("Loaction", "Hyderabad");
            Emp.Add("Status", true);

            foreach(string key in Emp.Keys)
            {
                Console.WriteLine($"{key} : {Emp[key]}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

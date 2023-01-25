using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class10 
    {
        static void Main()
        {
            //Creating instance of Customer class using Object Initializers.
            Customer c1 = new Customer { Id = 101, Name = "Scott", City = "Delhi", Balance = 15000.00, Status = true };
            Customer c2 = new Customer { Id = 102, Name = "Dave", City = "Mumbai", Balance = 10000.00, Status = true };
            Customer c3 = new Customer { Id = 103, Name = "Sunitha", City = "Chennai", Balance = 15600.00, Status = false };
            Customer c4 = new Customer { Id = 104, Name = "David", City = "Delhi", Balance = 22000.00, Status = true };
            Customer c5 = new Customer { Id = 105, Name = "John", City = "Kolkata", Balance = 34000.00, Status = true };
            Customer c6 = new Customer { Id = 106, Name = "Jane", City = "Hyderabad", Balance = 19000.00, Status = true };
            Customer c7 = new Customer { Id = 107, Name = "Kavitha", City = "Mumbai", Balance = 16500.00, Status = true };
            Customer c8 = new Customer { Id = 108, Name = "Steve", City = "Bengaluru", Balance = 34600.00, Status = false };
            Customer c9 = new Customer { Id = 109, Name = "Sophia", City = "Chennai", Balance = 6300.00, Status = true };
            Customer c10 = new Customer { Id = 110, Name = "Rehman", City = "Delhi", Balance = 9500.00, Status = true };
            Customer c11 = new Customer { Id = 111, Name = "Raj", City = "Hyderabad", Balance = 9800.00, Status = false };
            Customer c12 = new Customer { Id = 112, Name = "Rupa", City = "Kolkata", Balance = 13200.00, Status = true };
            Customer c13 = new Customer { Id = 113, Name = "Ram", City = "Bengaluru", Balance = 47700.00, Status = true };
            Customer c14 = new Customer { Id = 114, Name = "Joe", City = "Hyderabad", Balance = 26900.00, Status = false };
            Customer c15 = new Customer { Id = 115, Name = "Peter", City = "Delhi", Balance = 17400.00, Status = true };

            //Creating a list and adding added all the customers instances into the list

             List<Customer> Customers = new List<Customer>() { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15 };

            //implemening LINQ Queries for fetching the data from the List using LINQ to Objects.

            // var Coll=from c in Customers select c;

            //Fetching selected columns and giving alias names to columns: 
            //  var Coll = from c in Customers select new { c.Id, c.Name, c.City, Is_active = c.Status };

            //Order By clause:
            // var Coll = from c in Customers orderby c.Name select c;
            // var Coll = from c in Customers orderby c.Balance select c;
            // var Coll = from c in Customers orderby c.Balance descending select c;

            //Where Clause
            // var Coll = from c in Customers where c.Balance > 15000 select c;
            // var Coll = from c in Customers where c.City == "Hyderabad" select c;
            // var Coll = from c in Customers where c.City == "Bengaluru" && c.Balance > 15000 select c;
            // var Coll = from c in Customers where c.City == "Chennai" || c.Balance > 4000 select c;

            //Group by Clause
            // var Coll = from c in Customers group c by c.City into G select new { City = G.Key, Customers = G.Count() };
            // var Coll = from c in Customers group c by c.City into G select new { city = G.Key, MaxBalance = G.Max(c => c.Balance) };
            // var Coll = from c in Customers group c by c.City into G select new { city = G.Key, MinBalance = G.Min(c => c.Balance) };
            // var Coll = from c in Customers group c by c.City into G select new { city = G.Key, Total_Balance = G.Sum(c => c.Balance) };
            //var Coll = from c in Customers group c by c.City into G select new { city = G.Key, Avg_Balaance = G.Average(c => c.Balance) };

            //Having Clause

            // var Coll = from c in Customers group c by c.City into G where G.Count() > 2 select new { city = G.Key, Customers = G.Count() };
            // var Coll = from c in Customers group c by c.City into G where G.Max(c => c.Balance) > 25000 select new { city = G.Key, MaxBalance = G.Max(c=>c.Balance) }; 
            var Coll = from c in Customers group c by c.City into G where G.Min(c => c.Balance) < 10000 select new { city = G.Key, MinBalance = G.Min(c => c1.Balance) };




            foreach (var cust in Coll)
            {
                Console.WriteLine(cust);

            }
            Console.ReadLine();
        }
       
    }
}

using System;
using System.Collections.Generic; 

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
           // employee.Things = new List<string>();
            var Things = new List<string>();

            Things.Add("More");
            Things.Add("Stuff");
            Things.Add("Bobs");

            foreach (var thing in Things) 
            {
                Console.WriteLine(thing);
                Console.ReadLine(); 
            }
                

           



            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>();
            employee1.Things.Add(2);
            employee1.Things.Add(6);
            employee1.Things.Add(9);



            


        }
    }
}

using System;
using System.Text; 
using System.Collections.Generic; 

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Second Attempt 
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Bob", "And", "Chair" };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 2, 4, 5, 7 }; 

          foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
               
            }

            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);

            }
            Console.ReadLine(); 



        }
    }
}

using System;
using System.Collections.Generic; 

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            var Things = new List<string>();

            Things.Add("More"); //Are these things still linked to the propert of the employee class?
            Things.Add("Stuff");
            Things.Add("Bobs");

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>(); // how can identify this line and use it as arg in method below?
            var NumberThings = new List<int>();

            //employee1.Things.Add(2);
            //employee1.Things.Add(6);
            //employee1.Things.Add(9);
            //employee1.Things.Add(5);
             NumberThings.Add(2);
            NumberThings.Add(6);
            NumberThings.Add(8);



            employee.PrintMethod(Things);
            employee1.PrintMethod(NumberThings);

            Console.ReadLine(); 

        }
    }
}

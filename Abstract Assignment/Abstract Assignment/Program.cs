using System;

namespace Abstract_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Fname = "Sample";
            employee.Lname = "Student"; 
            employee.SayName();

        



            Console.ReadLine();

            IQuittable employeemorph = new Employee();
            employeemorph.Quit();

            Console.ReadLine(); 
        }
    }
}

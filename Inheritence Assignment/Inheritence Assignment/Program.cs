using System;

namespace Inheritence_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample"; // Why did I have to make the properties in person public? Shouldnt inheritance 
            //take care of that? My child class Employee could not access properties of parent class Person. 
            employee.LastName = "Student";
            employee.sayName();

            Console.ReadLine(); 
        }
    }
}

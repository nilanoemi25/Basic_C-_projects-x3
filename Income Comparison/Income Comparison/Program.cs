using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymus Income Protection Program \n Person1 \n Hourly Rate? ");
            string hourlyrate1 = Console.ReadLine();
            int hourlyrate01 = Int16.Parse(hourlyrate1);
            Console.WriteLine("Hours worked per week?");
            string perweek = Console.ReadLine();
            int perweek1 = Int16.Parse(perweek);
            Console.WriteLine("Person 2 \n Hourly Rate?");
            string hourlyrate2 = Console.ReadLine();
            int hourlyrate02 = Int16.Parse(hourlyrate2);
            Console.WriteLine("Hours worked per week?");
            string perweek2 = Console.ReadLine();
            int perweek02 = Int16.Parse(perweek2);

            // Maths for person 1 

            int total = hourlyrate01 * perweek1 * 52; 
            Console.WriteLine("Annual Salary of Person 1: \n" + total);


            // Maths for person 2 
            int total2 = hourlyrate02 * perweek02 * 52;
            Console.WriteLine("Annual Salary of Person 2: \n" + total2);

            Console.ReadLine();

        }
    }
}

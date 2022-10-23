using System;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Console.Read();

            Console.WriteLine("How many DUI violations have you had?");

            int violation = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets have you had?");

            int speeding = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            bool qualification = (age > 15 && violation == 0 && speeding <= 3);
            Console.WriteLine("Qualification:" + qualification);
            Console.ReadLine();

        }
    }
}

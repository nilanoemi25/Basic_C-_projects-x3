using System;

namespace Enum_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi user, what day is today? Choose from 1-7 ");
            string day = Console.ReadLine();

            DaysoftheWeek daysoftheweek = (DaysoftheWeek)Convert.ToInt32(day);  

            Console.WriteLine(daysoftheweek); 

        }
    }
}

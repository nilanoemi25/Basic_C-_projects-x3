using System;
using System.IO; 

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now + "Hi user, give me a number:");
            string answer = Console.ReadLine();

            DateTime usertime = DateTime.Parse(answer);

            TimeSpan future = usertime - DateTime.Now; 

            Console.ReadLine(); 

        }
    }
}

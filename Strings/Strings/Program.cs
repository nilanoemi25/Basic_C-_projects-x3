using System;
using System.Text; 

namespace Strings
{
    class Program
    {
        static void Main()
        {
            /*string s = "Hello World! + Hello Universe! + Hello Galaxy!";
            Console.WriteLine(s);

            string uppers = s.ToUpper();
            Console.WriteLine(uppers); */ 

            StringBuilder x = new StringBuilder("HELLO ");

            x.Append("there.");
            x.AppendLine("The weather is nice today.");
            x.AppendLine("It is not raining.");
            x.Append("Nor is it windy.");

            Console.WriteLine(x);
            Console.ReadLine(); 



        }
    }
}

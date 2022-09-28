using System;

namespace Assignment_Pitman
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pitman Training \n Student Daily Report \n What course are you in?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything?");
            string help = Console.ReadLine();
            Console.WriteLine("Where there any positive experiences you'd like to share? Please provide specifics!");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.Have a great day!");
            Console.ReadLine(); 


        }
    }
}

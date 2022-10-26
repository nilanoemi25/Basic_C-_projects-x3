using System;

namespace Price_Quote_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. What is the weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                    }
            else if ( weight < 50)
            {
                Console.WriteLine("What is the package width? ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package lenght?");
                int lenght = Convert.ToInt32(Console.ReadLine());

                if( width + height + lenght > 50)
                { Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day.");
                }
                else
                { int price = (width * height * lenght) / 100;

                    Console.WriteLine("The cost of delivery will be £ " + price); 
                }
            }
            
        }
    }
}

using System;

namespace While_Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number between 1 - 10");
            int guess = Convert.ToInt32(Console.ReadLine());

            /*
            while ( guess <= 10)
            { Console.WriteLine("That is a good guess. Try again");
                break; 
                }
            */
          

            
            do { Console.WriteLine("that is a great guess."); }

            while (guess < 10);
            
            Console.ReadLine();





        }
    }
}

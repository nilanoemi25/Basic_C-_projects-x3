using System;

namespace Exception_Handling_module_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());

                if ( age <= 0) 
                {
                    throw new ArgumentNullException(); 
                }

                Console.WriteLine("That means you were born in the year of : " + (2023 - age) + ".");
            }
            
            catch (ArgumentNullException)
            {
                Console.WriteLine("You have entered a negative or zero digit. Please try again");
            }
            catch (Exception )
            {
                Console.WriteLine("An error occured, try again. "); 
            }

        }
    }
}

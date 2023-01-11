using System;


    class Program
    {
        static void Main(string[] args)
        {
          try 
          {
            Console.WriteLine("Pick a number:");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number:");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            int NumberThree = NumberOne / NumberTwo;
            Console.WriteLine(NumberOne + "divided by " + NumberTwo + "equals" + NumberThree);
            Console.ReadLine();

        }
          catch (FormatException ex)
           {
            Console.WriteLine("Please type whole number.");
            return; 

           }
           catch(DivideByZeroException ex)
           {
            Console.WriteLine("Please don't divide by zero.");
           }
           catch(Exception ex)
           {
            Console.WriteLine(ex.Message);
           }
           finally
           {
            Console.ReadLine(); 
           }
            
        }

         

      

        
    }


using System;
using System.Collections.Generic; 


    class Program
    {
        static void Main(string[] args)
        {


        try
          {
            Console.WriteLine("Chose a number to divide by:");
            int userinput = Convert.ToInt32(Console.ReadLine());

            List<int> Numbers = new List<int>();
            Numbers.Add(1);
            Numbers.Add(5);
            Numbers.Add(8);
            Numbers.Add(10);

            foreach (int i in Numbers)
            {
                Console.WriteLine("The equations is: " + i + " / " + userinput + " = " + i / userinput);
            }

          }

        catch (FormatException ex)
          {
            Console.WriteLine("Please type numbers only");
            return; 
          }
        catch (DivideByZeroException ex)
          {
            Console.WriteLine("Please don't divide by zero");
            return; 

          }

        finally
        {
            Console.WriteLine("We have encountered a try catch block and proceeded with the programme accordingly.");
            Console.ReadLine(); 
        }
       

        

        }
    }


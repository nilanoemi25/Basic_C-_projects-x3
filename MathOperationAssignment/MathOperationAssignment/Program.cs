using System;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main()
        {
            //
            //Console.WriteLine("Choose a number."); 
            //string input = Console.ReadLine();
            //int num1 = Convert.ToInt32(input);
            //int result = num1 * 50;
            //Console.WriteLine(result);
            //Console.ReadLine();

            //Console.WriteLine("Choose a number.");
            //string input1 = Console.ReadLine();
            //int num2 = Convert.ToInt32(input1);
            //int result1 = num2 +25;
            //Console.WriteLine(result1);
            //Console.ReadLine();

            //Console.WriteLine("Choose a number.");
            //string input2 = Console.ReadLine();
            //int num3 = Convert.ToInt32(input2);
            //double result2 = num3 / 12.5; 
            //Console.WriteLine(result2);
            //Console.ReadLine();

            //Console.WriteLine("Choose a number.");
            //string input3 = Console.ReadLine();
            //int input4 = Convert.ToInt32(input3); 
            //bool thisOr = input4 > 50; 
            //Console.WriteLine(thisOr);
            //Console.ReadLine();

            Console.WriteLine("Choose a number:");
            string number = Console.ReadLine();
            int numb = Convert.ToInt32(number);
            int result = numb % 7;
            Console.WriteLine(result);
            Console.ReadLine(); 

        }
    }
}

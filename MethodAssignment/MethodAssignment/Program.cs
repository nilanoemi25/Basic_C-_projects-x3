using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a nummber to operate on: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstnumber = Class1.MyMethod(number);
            Console.WriteLine("First method: "+firstnumber);

            int secondnumber = Class1.MySecondMethod(number);
            Console.WriteLine("Second method:" + secondnumber);

            int thirdnumber = Class1.MyThirdMethod(number);
            Console.WriteLine("Third method:" + thirdnumber);

            Console.ReadLine(); 

        }
        
           


    }
}

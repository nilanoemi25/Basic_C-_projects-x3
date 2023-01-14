using System;

namespace Class_Method_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            School myschool = new School();

            Console.WriteLine("Hi user give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
           // myschool.myMethod(number, out int loop, 1); // First Method 
            //Console.ReadLine();

            //Overload method: 
            myschool.myMethod(number, 4, out int loop, 1);
            Console.ReadLine(); 
        }
    }
}

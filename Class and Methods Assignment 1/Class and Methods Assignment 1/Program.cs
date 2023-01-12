using System;

namespace Class_and_Methods_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paper myobj = new Paper();
            int thisresult = Paper.myMethod(1);

            Console.WriteLine("the result of using first method is: " + thisresult);

            int thatresult = Paper.myMethod(1.2f);
            Console.WriteLine("the result of using second method is: " + thatresult);

            int result = Paper.myMethod("3");
            Console.WriteLine("the result of using third method is: " + result); 

        }
    }
}

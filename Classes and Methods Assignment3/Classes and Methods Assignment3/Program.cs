using System;

namespace Classes_and_Methods_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            myMath.myMethod(1, 8);
            myMath.myMethod(number: 1, next: 8);
            Console.ReadLine();
        }
    }
}

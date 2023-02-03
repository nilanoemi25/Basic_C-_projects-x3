using System;

namespace Additional_Features_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string somewords = "Hello World";

            var somevalue = 5;

            //People people = new People(example, somevalue);

            People people1 = new People(somewords)
            {

            };

            Console.WriteLine(people1); 
        }
    }
} 

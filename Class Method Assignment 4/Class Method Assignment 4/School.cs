using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_Assignment_4
{
    class School
    {
        public void myMethod(int number, out int loop, int times = 1)

        {
            loop = 0;

            for (int i = 0; i < times; i++) 
            {
                loop++; 
                int a = number / 2;
                Console.WriteLine("The result of the method is: " + a);
            }
            
            
        }

        public void myMethod(int number, int second, out int loop, int times = 0)
        {

            loop = 0;
            

            for (int i = 0; i<times; i++)

            {
                loop++;
                int a = number / 2;
                int b = second / 2;
                Console.WriteLine("The result of this loop is: " + a + " and " + b); 
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_Methods_Assignment_1
{
    class Paper
    {
        public static int myMethod(int number)
        {
            int result = number + 1;
            return result; 
        }

        public static int myMethod(float number)
        {
            float result = number + 2;
            int finalresult = (int)result;
            return finalresult; 
        }

        public static int myMethod(string String)
        {
            int number = Convert.ToInt32(String);
            int finalresult = number + 3;
            return finalresult; 
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Methods_Assignment_2
{
    class Rock
    {
        public  int myMethod(int number, int optionalnumber = 0)
        {
            int result = number + optionalnumber + 1;
            
            Console.WriteLine(result);
            return result; 
        }

    }
}
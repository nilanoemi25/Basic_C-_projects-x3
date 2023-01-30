using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }

        public void PrintMethod(List<T> Print)
        {
            Console.WriteLine(Print); 
        }

    }
}

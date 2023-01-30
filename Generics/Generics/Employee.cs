using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }

        //public void printmethod(List<T> print)
        //{
        //    Console.WriteLine(print); 
        //}

    }
}

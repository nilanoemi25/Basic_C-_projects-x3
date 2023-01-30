using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Assignment
{
    public abstract class Person
    {
        public string Fname { get; set; } 
        public string Lname { get; set; }

        public abstract void SayName(); 


    }
}

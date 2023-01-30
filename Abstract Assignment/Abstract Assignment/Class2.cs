using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Assignment
{
    public class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(Fname + " " + Lname); 
        }

        public void Quit ()
        {
            throw NotImplementedException(); 
        }
    }
}

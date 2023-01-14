using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Assignment
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void sayName()
        {
            string fullname = FirstName + " " + LastName;
            Console.WriteLine($"Name: {fullname}", fullname );
        }
    }

    
}

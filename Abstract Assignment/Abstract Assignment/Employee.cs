using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Assignment
{
    public class Employee: Person, IQuittable

    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine(Fname + " " + Lname); 
        }

        public void Quit ()
        {
            throw new NotImplementedException(); 
        }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false; 
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (!emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false; 
        }
    }
}

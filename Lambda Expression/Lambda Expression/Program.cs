using System;
using System.Text;
using System.Collections.Generic;
using System.Linq; 

namespace Lambda_Expression
{
    class Program
    {
        static void Main()
        {
            //Creating instances of Employee class 10 times
            Employee employee = new Employee();
            employee.Fname = "Joe";
            employee.Lname = "OReilly";
            employee.Id = 1;

            Employee employee1 = new Employee();
            employee1.Fname = "Jack";
            employee1.Lname = "Sparrow";
            employee1.Id = 2;

            Employee employee2 = new Employee();
            employee2.Fname = "Joe";
            employee2.Lname = "Sparrow";
            employee2.Id = 3;

            Employee employee3 = new Employee();
            employee3.Fname = "Adam";
            employee3.Lname = "Rain";
            employee3.Id = 4;

            Employee employee4 = new Employee();
            employee4.Fname = "Jessica";
            employee4.Lname = "Fitz";
            employee4.Id = 5;

            Employee employee5 = new Employee();
            employee5.Fname = "Hailey";
            employee5.Lname = "Ryan";
            employee5.Id = 6;

            Employee employee6 = new Employee();
            employee6.Fname = "Rebecca";
            employee6.Lname = "Soans";
            employee6.Id = 7;

            Employee employee7 = new Employee();
            employee7.Fname = "Morris";
            employee7.Lname = "Blue";
            employee7.Id = 8;

            Employee employee8 = new Employee();
            employee8.Fname = "Morris";
            employee8.Lname = "Blue";
            employee8.Id = 9;

            Employee employee9 = new Employee();
            employee9.Fname = "Morris";
            employee9.Lname = "Blue";
            employee9.Id = 10;

            //Creating my List with Employee as type
            List<Employee> myList = new List<Employee>();
            myList.Add(employee);
            myList.Add(employee1);
            myList.Add(employee2);
            myList.Add(employee3);
            myList.Add(employee4);
            myList.Add(employee5);
            myList.Add(employee6);
            myList.Add(employee7);
            myList.Add(employee8);
            myList.Add(employee9);

            //Foreach Version

            //foreach (Employee item in myList)
            //{
            //    List<Employee> loopylist = new List<Employee>();

            //    if (item.Fname == "Joe")
            //    {
            //        loopylist.Add(item);
            //        Console.WriteLine(item.Fname + "" + item.Lname); 
            //    }
            //}
            //Console.ReadLine();


            // Lambada Expression Version 

            List<Employee> lame = myList.Where(x => x.Fname == "Joe").ToList(); 

            Console.WriteLine(lame);

            // List of employees Id greater than 5 

            List<Employee> lamelist = myList.Where(y => y.Id >= 5).ToList(); 

        }


    }
}

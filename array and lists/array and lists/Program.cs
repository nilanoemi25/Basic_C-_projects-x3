using System;
using System.Collections.Generic; 



    class Program
    {
        static void Main( )
        {
        //int[] numArray = new int [5];
        //numArray[0] = 1;
        //numArray[1] = 24;
        //numArray[2] = 200;
        //numArray[3] = 400;
        //numArray[4] = 2000;

        //int[] numArray1 = new int [] { 1,24,200,400,2000}; 

        //Console.WriteLine(numArray1[2]


        //string[] genericString = new string[] { "Hello", "Bob", "And", "Mary", "!" };
        //Console.WriteLine("Pick a number between 0 and 4.");

        //int userstring = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(genericString[userstring]);
        //Console.ReadLine();
        //try
        //{
        //    int[] genericNumber = new int[] { 2, 5, 7, 8, 98, 200 };
        //    Console.WriteLine("Pick a number between 0 and 5.");

        //    int usernumber = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(genericNumber[usernumber]);
        //    Console.ReadLine();
        //} 

        //catch
        //{

        //    Console.WriteLine("The number is out of range."); 
        //}

        List<string> Papers = new List<string>();
        Papers.Add("Documents");
        Papers.Add("Visa");
        Papers.Add("Passport");
        Papers.Add("Docket");
        Papers.Add("Folder");

        Console.WriteLine("Choose one number between 0 and 4.");

        int listindex = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Papers[listindex]);
        Console.ReadLine();

    }
}


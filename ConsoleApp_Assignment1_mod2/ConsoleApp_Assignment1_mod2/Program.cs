using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //string[] pets = new string[] {"fish", "dog", "kitties", "hamster", ""};


        //Console.WriteLine("Hey user, name house animal.");
        //string name = Console.ReadLine();



        ////for (int i = 0; i < pets.Length; i++)
        ////{
        ////    pets[4] = name;
        ////    Console.WriteLine(pets[i]); 
        ////}

        //for (int i = 0; i < pets.Length; i++)
        //{

        //        pets[4] = name;
        //    Console.WriteLine(pets[i]);
        //    Console.WriteLine(); 
        //}
        //// sorry I thought the assingment needed me to leave a line free so hence I did this. 

        //Console.ReadLine();

        ////infinite loop Console App part 2 
        //bool housepets = true;
        //while (  housepets == true ) 

        //    {
        //    Console.WriteLine("Infinite loop once."); break;  }

        ////Console App part 3 

        //for( int i = 0; i < pets.Length; i++)
        //{
        //    if(pets[i].Length < 5)
        //    {
        //        Console.WriteLine(); 
        //        Console.WriteLine( pets[i] + " has less than 5 letters."); }
        //}

        //for( int i = 0; i < pets.Length; i++)
        //{
        //    if (pets[i].Length <= 4 )
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine(pets[i] + " has 4 or less letters. \n");
        //    }
        //}

        List<string> unique = new List<string>() { "There", "are", "many", "Taylor", "Swift", "fans", "in ", "the", "world" };
        Console.WriteLine("Choose a random word:"); 
        string userinput = Console.ReadLine();

        for (int i = 0; i < unique.Count; i++)
         
        {

            if(userinput == unique[10])
                try
                {
                    Console.WriteLine("This should not appear on screen.");
                }
                catch
                {
                    if (userinput == unique[i])

                    {
                        Console.WriteLine("That word is a match!");
                    }

                else
                    {
                        Console.WriteLine("No match.");
                    }
                }

            // Why does it quit the program instead of going on with the catch? :D 
        }

        Console.ReadLine(); 
           
    }








}



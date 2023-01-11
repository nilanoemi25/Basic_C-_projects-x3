using System;
using System.Collections.Generic;


    class Program
{
    static void Main(string[] arg)
    {
        //int[] testScores = { 99, 98, 97, 96, 77, 54, 34, 87, 89, 99 };
        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing score:" + testScores[i]);

        //    } 

        //}
        //Console.ReadLine(); 


        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(88);
        //testScores.Add(69);
        //testScores.Add(89);
        //testScores.Add(82);
        //testScores.Add(84);

        //foreach( int numbers in testScores)
        //{
        //    if(numbers > 80)
        //    {
        //        Console.WriteLine(numbers);
        //    }
        //}
        //Console.ReadLine(); 

        //List<string> Names = new List<string>();
        //Names.Add("Jesse");
        //Names.Add("Chloe");
        //Names.Add("Emily");
        //Names.Add("Star");

        //foreach(string fname in Names)
        //{
        //    Console.WriteLine(fname); 
        //}
        //Console.ReadLine(); 

        List<int> testScores = new List<int>() { 98, 99, 87, 43, 45, 76 };
        List<int> passingScores = new List<int>();

        foreach( int score in testScores)
        {
            if(score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine(); 
    }
}
 

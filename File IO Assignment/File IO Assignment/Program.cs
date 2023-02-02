using System;
using System.IO; 

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi user, give me a number:");
            string answer = (Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"D:\Nila-PC\Pitman Training\Basic C# Pr\Basic_C-_projects-x3\File IO Assignment\log.txt", true))
            {
                file.WriteLine(answer); 
            }

            Console.ReadLine(); 

        }
    }
}

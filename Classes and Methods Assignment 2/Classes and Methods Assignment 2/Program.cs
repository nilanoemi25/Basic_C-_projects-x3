using System;

namespace Classes_and_Methods_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rock rock = new Rock();

            Console.WriteLine("Hey user, chose a number:");
            int userinput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me another number!: ");
            string optionaluserinput = Console.ReadLine();
            bool optional = string.IsNullOrEmpty(optionaluserinput);

            if (optional == true)
            {
                rock.myMethod(userinput);
                
                Console.ReadLine();
            }
            else
            {
                int optionaluser = Convert.ToInt32(optionaluserinput);
                rock.myMethod(userinput, optionaluser);
               
                Console.ReadLine();
            }
            

            //try
            //{
            //    int optionaluserinput;
            //    Console.WriteLine("Thanks, give me another number: (or not)");
            //    optionaluserinput = Convert.ToInt32(Console.ReadLine());
            //}
            
            //catch 
            //{
            //    int optionaluserinput = 1;
            //    return; 
       
            //}
            //finally {
                
            //    int granite = Rock.myMethod(userinput, optionaluserinput);
            //    Console.WriteLine(granite);
            //    Console.ReadLine();
            //}


        }
    }
}

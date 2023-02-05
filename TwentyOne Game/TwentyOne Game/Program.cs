using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;
using System.IO; 

namespace TwentyOne_Game
{
    class Program
    {
        static void Main(string[] args )
        {
            const string CasinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name!", CasinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0; 
            while(!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please use digits only, no decimals.");
            }

            Console.WriteLine("Hello {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid(); 
                Game game = new TwentyOneGame();
                game += player;

                using (StreamWriter file = new StreamWriter(@"D:\Nila-PC\Pictures\Pitman Training\Basic C# Pr\Basic_C-_projects-x3\TwentyOne Game\log.txt", true))
                {
                    file.WriteLine(player.Id);
                    
                }

                player.isActivelyPlaying = true; 
                while (player.isActivelyPlaying && bank > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out;");
                        Console.ReadLine();
                        return; 

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your system administrator!");
                        Console.ReadLine();
                        return; 
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine(); 


        }

        private static void UpdateDBwithExceptions(Exception ex)
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog="TwentyOne;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                      

        }

    }
}

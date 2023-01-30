using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne_Game
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); 

        public virtual void ListPlayer()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name); 
            }
        }

    }
}

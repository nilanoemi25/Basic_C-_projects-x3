﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Casino.Interfaces; 

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach( Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false; 

            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(); 

            foreach(Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bets!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);

                    if (!validAnswer) Console.WriteLine("Please use digits only, no decimals.");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security, kick this person out!");  
                }

                bool successfullybet = player.Bet(bet); 
                if(!successfullybet)
                {
                    return; 
                }
                Bets[player] = bet; 
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);

                    if (i == 1)
                    {
                        bool BlackJack = TwentyOneRules.CheckforBlackJack(player.Hand);
                        if (BlackJack)
                        {
                            Console.WriteLine("Blackjack!  {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write(" Dealer");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool BlackJack = TwentyOneRules.CheckforBlackJack(Dealer.Hand);
                    if (BlackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses! ");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                            return; 
                        }
                        
                    } 
                    
                    
                } //return; // issue here is that it does not go to line 75 next. 

            } 

           foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }


                
                Console.WriteLine("\n\nHit or stay? ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "stay")
                {
                    player.Stay = true;
                    break;
                }
                else if (answer == "hit")
                {
                    Dealer.Deal(player.Hand); 
                }
                bool busted = TwentyOneRules.IsBusted(player.Hand);
                if (busted)
                {
                    Dealer.Balance += Bets[player];
                    Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                    Console.WriteLine("Do you want to play again? ");
                    answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        } 
                        
                    }
                }
            }
            
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); // not sure if in correct location 
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while( !Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if( Dealer.Stay )
            {
                Console.WriteLine("Dealer is staying.");
            }
            if(Dealer.isBusted)
            {
                Console.WriteLine("Dealer is busted.");
                foreach(KeyValuePair<Player,int> entry in Bets )
                {
                    Console.WriteLine(" {0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value; 
                }
                return; 

            } 
            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                {
                    if (playerWon == null)
                    {
                        Console.WriteLine("Push! No one wins.");
                        player.Balance += Bets[player];
                        Bets.Remove(player);

                    }
                    else if (playerWon == true)
                    {
                        Console.WriteLine("{0}  won {1}!", player.Name, Bets[player]);
                        player.Balance += (Bets[player] * 2);
                        Dealer.Balance -= Bets[player];
                    }
                    else
                    {
                        Console.WriteLine("Delear wins {0}!", Bets[player]);
                        Dealer.Balance += Bets[player]; 

                    }
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower(); 
                if ( answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true; 
                }
                else
                {
                    player.isActivelyPlaying = false; 

                }
            }

        }
        
        

        public void WalkAway(Player player)
        {
            throw new NotImplementedException(); 
        }

       
    }
}

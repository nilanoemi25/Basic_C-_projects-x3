﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne_Game
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();  
            List<string> Suits = new List<string> { "Clubs ", "Hearts ", "Diamonds ", "Spades" };
            List<string> Faces = new List<string>
            {
                "One", "Two", "Three", "Four", "Five", "Six", "Seven", 
                "Eight", "Nine", "Ten", "Jack", "King", "Queen", "Ace"
            };

            foreach (string face in Faces)
            
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); 

                }

            }
        }
        public List <Card> Cards { get; set; }
    }
}

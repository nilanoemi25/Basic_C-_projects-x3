﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne_Game
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
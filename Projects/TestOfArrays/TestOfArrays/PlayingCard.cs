using System;
using System.Collections.Generic;
using System.Text;

namespace TestOfArrays
{
    class PlayingCard
    {
        public string CardColor { get; set; }
        public int CardValue { get; set; }
        public string CardNominations { get; set; }

        static Random random = new Random();
        public string[] cardNominations =
        {
            "Ace of","Two of", "three of", "four of", "five of", "six of", "seven of","eight of", "nine of", "ten of", "Jack of", "Queen of", "King of"
        };

        public string[] cardColor =
        {
            "Clubs","Hearts","Spades","Diamonds"
        };

        public void GiveCardValue()
        {
            int cardValue = random.Next(0, 12);
            GiveCardNomination(cardValue);
            
            MakeACard(int.Parse(cardNominations).ToString, cardValue, cardColor);
        }

        public string GiveCardNomination (int cardValue)
        {
            return cardNominations[cardValue];
        }

        

        public void MakeACard(int cardValue, string[] cardNominations, string[] cardColor)
        {
            

        }


    }
}

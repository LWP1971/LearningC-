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



        public string MakeACard()
        {
            GiveCardValue();
            string result = ($"Your card is the {CardNominations}{CardColor}.");
            return result;
        }


        public void GiveCardValue()
        {
            int cardValue = random.Next(0, 12);
            GiveCardNomination(cardValue);
        }


        public void GiveCardNomination(int cardValue)
        {
            string[] cardNominations = {"Ace of ","Two of ", "three of ", "four of ", "five of ", "six of ", "seven of ","eight of ", "nine of ", "ten of ", "Jack of ", "Queen of ", "King of "};
            CardNominations = cardNominations[cardValue];
            GiveCardColor();
        }

        public string GiveCardColor()
        {
            int cardColor = random.Next(0, 3);
            string[] cardColors = {"Clubs","Hearts","Spades","Diamonds"};
            CardColor = cardColors[cardColor];
            string theResultingCard = string.Join(CardNominations,CardColor);
            return theResultingCard;
            
        }
}
}
    

        

 

    







        




    


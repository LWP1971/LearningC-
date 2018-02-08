using System;
using System.Collections.Generic;
using System.Text;

namespace TestOfArrays
{
    class DeckOfCards
    {


        public bool CardAlreadyInDeck { get; set; }

        public Dictionary<int, string> theDeckOfCards;
        

        public void AddToMyDeck (string TheResultingCard)
        {
            for (int i = 0; i < 51; ++i)
            {
                theDeckOfCards.Add(i, TheResultingCard);
            }
        }

    }
}

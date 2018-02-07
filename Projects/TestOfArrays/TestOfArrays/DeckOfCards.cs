using System;
using System.Collections.Generic;
using System.Text;

namespace TestOfArrays
{
    class DeckOfCards
    {
        public bool CardAlreadyInDeck { get; set; }
        public Dictionary<int, string> TheDeckOfCards { get; set; }

        PlayingCard playingcard = new PlayingCard();


        public void AddToMyDeck ()
        {
            for (int i = 0; i < 51; ++i)
            {
                TheDeckOfCards.Add(i,playingcard.TheResultingCard);
            }
        }

    }
}

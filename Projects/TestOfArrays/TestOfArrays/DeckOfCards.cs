using System;
using System.Collections.Generic;
using System.Text;

namespace TestOfArrays
{
    class DeckOfCards
    {


        //public bool CardAlreadyInDeck { get; set; }

        public Dictionary<int, PlayingCard> theDeckOfCards = new Dictionary<int, PlayingCard>();
        

        public void AddToMyDeck(PlayingCard TheResultingCard)
        {
            for (int i = 0; i < 51; ++i)
            {
                theDeckOfCards.Add(i, TheResultingCard);
            }
        }

        public void Populate()
        {
            for (int i = 0; i < 51; ++i)
            {
                var playingCard = new PlayingCard();
                playingCard.MakeACard();
                theDeckOfCards.Add(i, playingCard);
            }
        }

    }
}

using System;


namespace TestOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var playingCard = new PlayingCard();
            var deckOfCards = new DeckOfCards();

            bool continueProgram = false;

            while (!continueProgram)
            {
                Console.WriteLine(playingCard.MakeACard());

                deckOfCards = new DeckOfCards();
                deckOfCards.AddToMyDeck(PlayingCard.theResultingCard);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}


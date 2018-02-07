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



                //var deckOfCards = new DeckOfCards(playingCard);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}


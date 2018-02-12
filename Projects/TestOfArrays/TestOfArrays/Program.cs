using System;


namespace TestOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool continueProgram = false;

            while (!continueProgram)
            {
                var deckOfCards = new DeckOfCards();
                deckOfCards.Populate();

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}


using System;
using System.Collections.Generic;



namespace MethodExperimentsApplication

{
    class Program

    {
        static void Main(string[] args)

        {
            List<string> insults = new List<string>()
            {
                "what a poor choice",
                "you are french, are you not?",
                "you may be wiser than you look",
                "are any of your relatives belgian?",
                "why would you eat that?",
                "good choice! you could almost be german"
            };

            List<string> sausages = new List<string>()
            {
                "bratwurst with sauerkraut",
                "krakauer with lots of fresh mustard",
                "red boiled sausage with keeeetsjoooop"
            };

            bool programRun = true;

            while (programRun)
            {
                Console.WriteLine("SILENCE! We shall now determine your favorite sjerman schnackckh!");
                Blankline();
                int sausageNumber = 1;

                foreach (string type in sausages)
                {
                    Console.WriteLine(sausageNumber + "- " + type);
                    sausageNumber += 1;
                }

                string aWord = YourFavoriteSausage(sausages);
                string aDeclaration = "you love ";
                string exclamationWurst = MyLoveForSausages(aDeclaration) + MakeTheWurstGreatAgain(aWord);

                Console.Clear();
                Console.WriteLine(exclamationWurst);
                Blankline();
                Console.WriteLine(insults[RandomInsultPicker(insults)].ToUpper()+"!!!");
                Console.ReadKey();
                Console.Clear();
            }
        }


        public static string MakeTheWurstGreatAgain(string aWord)
        {
            string theGreatestWurst = aWord.ToUpper();
            return theGreatestWurst;
        }

        public static string MyLoveForSausages(string aDeclaration)
        {
            string trueLove = aDeclaration.ToUpper();
            return trueLove;
        }

        public static string YourFavoriteSausage(List<string> sausages)
        {
            string invalidChoice = ("nothing in this world! You must choose!");
            Blankline();
            Console.WriteLine("You must choose your favorite sausage combination now!");
            Blankline();
            Console.WriteLine("Select a number corresponding to your sausage. SCHNELL!");
            ConsoleKeyInfo choice = Console.ReadKey();

            if (choice.KeyChar == '1')
            {
                return (sausages[0]);
            }

            if (choice.KeyChar == '2')
            {
                return (sausages[1]);
            }
            if (choice.KeyChar == '3')
            {
                return (sausages[2]);
            }
            else return invalidChoice;
        }
        static Random randomize = new Random();

        public static int RandomInsultPicker(List<string> insults)
        {
            int something = randomize.Next(0, insults.Count);
            return something;
        }

        public static void Blankline() => Console.WriteLine("");

    }
}







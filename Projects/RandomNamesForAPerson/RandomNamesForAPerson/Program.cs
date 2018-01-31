using System;

namespace RandomNamesForAPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Random rnd = new Random();
                string[] firstSyllables = { "Hen", "Kar", "Bør", "Be",
                                "Birt", "Sam", "Fio", "Ben",
                                "Pet", "Po", "Na" };
                string[] lastSyllables = { "sten", "bo", "nulla", "ter",
                                  "ren", "dia", "line", "lie",
                                  "ge", "ver" };


                Console.WriteLine("Hello. Do you need a new name? Y/N");
                string userAnswer = Console.ReadLine();
                int newUserAnswer = int.Parse(userAnswer);

                if (newUserAnswer = ("y");
                {

                    int mIndex = rnd.Next(0, firstSyllables.Length);
                    int fIndex = rnd.Next(0, lastSyllables.Length);


                    Console.WriteLine("Your new name is:     {0}", firstSyllables[mIndex] + lastSyllables[fIndex]);
                }
            }
        }

              
            }

        }

    }

}
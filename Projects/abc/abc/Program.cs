using System;
using System.Collections.Generic;
using System.Linq;

namespace MerryChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            string laugh = "ho";
            string hyphen = "-";
            string greeting = "Merry christmas";
            string exclamation = "!";
            int hoCount = 3;

            {
                //Console join - IEnum solution

                //Console.Write(string.Join("", Enumerable.Repeat((laugh.ToUpper() + hyphen, (hoCount - 1))) + laugh.ToUpper() + " " + greeting.ToUpper() + exclamation);
                //Console.ReadKey();
            }
            {
                //strings-to-list-to-array-solution

                List <string> tisTheSeasonToBeJolly = new List<string>();

                tisTheSeasonToBeJolly.Add(laugh);
                tisTheSeasonToBeJolly.Add(hyphen);
                tisTheSeasonToBeJolly.Add(greeting);
                tisTheSeasonToBeJolly.Add(exclamation);

                tisTheSeasonToBeJolly.ToArray();

                Console.Write(tisTheSeasonToBeJolly[1]);
                Console.ReadKey();

            }


        }


    }
}

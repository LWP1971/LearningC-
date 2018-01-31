using System;

namespace Exercises_week_3
{

    class Program
    {
        static void Main(string[] args)
        {
            // To make these exercises manageable, solve each sub-exercise (1A, 1B, etc.) completely before proceeding to the next one.
            // The sub-exercises modify your existing code, so you shouldn't write a separate chunk of code for each sub-exercise (unless you want to).

            // EXERCISE 1

            int repeat = 10;
            int startNumber = 4;
            int stepNumber = 3;

            // 1A. Write a while loop. It should run as many times as the "repeat" variable states. Write the same line of text to the console each time.

            //int Counter = startNumber;

            //while (Counter < repeat + startNumber)

            {
                //Console.WriteLine("Dette loop har kørt " + Counter + " gange.");

                //if (Counter % 2 == 0)
                {
                    //Console.WriteLine("Dette tal er lige");
                }

                //else
                {
                    //Console.WriteLine("Dette tal er ulige");
                }
                //Counter = Counter + stepNumber;
            }



            // 1B. Modify the outputted line so it writes the number of times the loop has been running on screen (1, 2, 3, 4, and so on). OK
            // 1C. Modify the numbering, so it begins counting from "startNumber", and still adds 1 each time (4, 5, 6, 7, and so on). It should still run "repeat" TIMES in total. OK
            // 1D. Modify the numbering, so it adds "stepNumber" instead of 1 each time (4, 7, 10, 13, and so on).
            // 1E. Your solution should use the variables above, and if their values are changed, it should be reflected when we run the loop. It should have no fixed upper limits for repeat.
            // 1F. In addition to writing the current number, also write whether that number is even or odd (4 is even, 7 is odd, 10 is even, 13 is odd, and so on).

            // EXERCISE 2

            // The local scouts puts their members in a certain group, depending on their age.
            // 0 - 5 years: haletudser
            // 6 - 7 years: bævere
            // 8 - 10: ulveunger
            // 11 - 14: tropspejdere
            // 15 - 16: seniorspejdere
            // 17 - (no limit): klanspejdere












            // 1A. Construct an if / else if / else statement that assigns the group depending on the age.


            bool isScoutleader = false;
            int scoutAge = 12;

                

            if (isScoutleader && scoutAge >= 15)
            {
                Console.WriteLine("Du er leder!");
            }
            if (isScoutleader && scoutAge < 15)
            {
               Console.WriteLine("Du er enten ikke gammel nok til at være leder, eller du er ikke leder.");
            }

            //Console.WriteLine("Hej Spejder. Indtast din alder:");



            if (!isScoutleader)

            {


                Console.WriteLine("Du hører til hos gruppen: ");


                if (scoutAge > 0 && scoutAge < 5)
                {
                    Console.WriteLine("Haletudser");
                }

                else if (scoutAge >= 6 && scoutAge <= 7)
                {
                    Console.WriteLine("Bævere");
                }

                else if (scoutAge >= 8 && scoutAge <= 10)
                {
                    Console.WriteLine("Ulveunger");
                }

                else if (scoutAge >= 11 && scoutAge <= 14)
                {
                    Console.WriteLine("Tropspejdere");
                }

                else if (scoutAge >= 15 && scoutAge <= 16)
                {
                    Console.WriteLine("Seniorspejdere");
                }

                else if (scoutAge > 17)
                {
                    Console.WriteLine("Klanspejdere");
                }
            }

                Console.ReadKey();


                // 1B. However, if you are a scout leader, you will always be assigned to the "Ledere" group, no matter what your age is.
                // 1C. But they do require that you are at least 15 years of age to become a leader, so if you are less than 15 and a leader, we should write an error.





        }
    }
}

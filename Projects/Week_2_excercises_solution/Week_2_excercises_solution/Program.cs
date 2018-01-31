using System;

namespace Week_2_excercises_solution
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

            // 1A. Write a while loop.

            int counter = startNumber;

            while (counter < repeat * startNumber)

            {
                Console.WriteLine("Nu kører tælleren! Den har nu kørt " + counter + " gange.");

                counter = counter + stepNumber;

            }




            // It should run as many times as the "repeat" variable states. Write the same line of text to the console each time. OK
            // 1B. Modify the outputted line so it writes the number of times the loop has been running on screen (1, 2, 3, 4, and so on). OK
            // 1C. Modify the numbering, so it begins counting from "startNumber", and still adds 1 each time (4, 5, 6, 7, and so on). It should still run "repeat" TIMES in total. 
            // 1D. Modify the numbering, so it adds "stepNumber" instead of 1 each time (4, 7, 10, 13, and so on).
            // 1E. Your solution should use the variables above, and if their values are changed, it should be reflected when we run the loop. It should have no fixed upper limits for repeat.
        }
    }
}

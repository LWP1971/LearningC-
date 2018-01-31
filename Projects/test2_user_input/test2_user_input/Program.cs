using System;

namespace test2_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;


            while (continueProgram)
            {
                bool isScoutLeader = false;



                Console.WriteLine("Hvor gammel er du, Spejder?:  ");

                int x;

                if (int.TryParse(Console.ReadLine(), out x))

                {
                    //Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Det var ikke et tal!");
                    //Returnér til spørgsmål...
                }

                int scoutAge = x;


                //Test af min. 15 år for ledere

                if (isScoutLeader && scoutAge >= 15)
                {
                    Console.WriteLine("Du er leder!");
                }
                if (isScoutLeader && scoutAge < 15)
                {
                    Console.WriteLine("Du er enten ikke gammel nok til at være leder, eller du er ikke leder.");
                }


                //Kategorisering af ikke-ledere

                if (!isScoutLeader)

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




                // 1B. However, if you are a scout leader, you will always be assigned to the "Ledere" group, no matter what your age is.
                // 1C. But they do require that you are at least 15 years of age to become a leader, so if you are less than 15 and a leader, we should write an error.

            }
        }
    }
}
﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace MXmas
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

                    Console.Write(string.Join("", Enumerable.Repeat((laugh.ToUpper() + hyphen), (hoCount - 1))) + laugh.ToUpper() + " " + greeting.ToUpper() + exclamation);
                    Console.ReadKey();
                }
            {
                //strings-to-list + for-loops solution


                List<string> tisTheSeasonToBeJolly = new List<string>();
                { 
               
                }
                {
                    tisTheSeasonToBeJolly.Add(laugh.ToUpper());
                    tisTheSeasonToBeJolly.Add(hyphen);
                    tisTheSeasonToBeJolly.Add(greeting.ToUpper());
                    tisTheSeasonToBeJolly.Add(exclamation);
                }
                laugh.ToUpper();
                greeting.ToUpper();   

                for (int shakeMyBellyLikeABigBowlOfJelly = 0; shakeMyBellyLikeABigBowlOfJelly < 2; shakeMyBellyLikeABigBowlOfJelly++)
                {
                    Console.Write((tisTheSeasonToBeJolly [0]+ tisTheSeasonToBeJolly [1]));

                }
                Console.Write(tisTheSeasonToBeJolly[0] + " ");

                tisTheSeasonToBeJolly.Clear();



                for (int j = 0; j < greeting.Length; j++)
                {
                    Char c = greeting.ToUpper()[j];
                    
                    {
                        Console.Write(c);
                    }

                }
                Console.Write(exclamation);



                    Console.ReadKey();

                }


            }


        }
    }


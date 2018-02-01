using System;
using System.Collections.Generic;
namespace ClassExperiment
{
    public class Presentation
    {


        
        public void PresentTheBoxMeasures(List<int> measureList)
        {
            Console.WriteLine("This program is now going to generate 3 random-length sides which form a box, and provide you with its volume.");
            BlankLine();
            Console.WriteLine("Do press any key in order to release the unbearable suspense of waiting for the random box measures!");
            Console.ReadKey();
            Console.Clear();
           
                for (int i = 0; i < measureList.Count; i++)
                Console.WriteLine($"Boxside no.{i+1} is {measureList[i]}cm."); 
            
        }


        public void PresentTheBoxVolume (int volume)
        {
            BlankLine();
            Console.WriteLine($"The volume of the box is {volume}cm3.");
        }


        public void BlankLine()
        {
            Console.WriteLine("");
        }
    }
}

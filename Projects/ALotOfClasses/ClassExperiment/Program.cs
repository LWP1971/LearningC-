using System;
using System.Collections.Generic;

namespace ClassExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box();
            var presentTheBox = new Presentation();       

            var measureList = box.GenerateBoxMeasures();
            var volume = box.GenerateBoxVolume(measureList);
            var measureNames = box.InsertMeasureNames();

            presentTheBox.PresentTheBoxMeasures(measureList);
            presentTheBox.PresentTheBoxVolume(volume);
            Console.ReadKey();
        }
    }
}

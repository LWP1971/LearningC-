using System;
using System.Collections.Generic;
namespace ClassExperiment
{
    public class Box
    {
        //public List<Measurenames> Measures { get; set; }
        //Variables
        public List<int> measureList = new List<int>();
        public List<string> measureNames = new List<string>()
        {
            "height",
            "width",
            "depth",
            "volume"
        };

        public Random boxRandomMeasures = new Random();


        //Executables

        public List<int> GenerateBoxMeasures()
        {
            while (measureList.Count <= 2)
            {
                int boxMeasure = boxRandomMeasures.Next(1, 10);
                measureList.Add(boxMeasure);
            }
            return measureList;

        }


        public int GenerateBoxVolume(List<int> measureList)
        {
            int boxVolume = (measureList[0] * measureList[1] * measureList[2]);
            return boxVolume;
        }



        public string InsertMeasureNames(List<string> measureNames)
        {
            int counter = 0;

            while (counter <= measureNames.Count)
            {
                foreach (string measurename in measureNames)
                {
                    return measurename;
                }
                counter += 1;

            }
            return "";
        }
    }
}









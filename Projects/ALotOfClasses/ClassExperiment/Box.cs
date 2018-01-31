using System;
namespace ClassExperiment
{
    public class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public string Color = "Red";

        public Random measures = new Random();

        public void GenerateBox()
        {
            int boxHeight = measures.Next(1, 10);
            Height = (boxHeight);
            int boxWidth = measures.Next(1, 10);
            Width = (boxWidth);
            int boxDepth = measures.Next(1, 10);
            Depth = (boxDepth);

            int volume = Height * Width * Depth;

         

        }

    }
}








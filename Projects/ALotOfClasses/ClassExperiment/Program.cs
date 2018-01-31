using System;

namespace ClassExperiment
{
    class Program
    {
        static void Main(string[] args)
        {

            var box = new Box();
            var presentTheBox = new Presentation();       

            box.GenerateBox();
            presentTheBox.PresentTheBox();

        }
    }
}

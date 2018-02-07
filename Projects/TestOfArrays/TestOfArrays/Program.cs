using System;

namespace TestOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new Arrays();
            var gotTheRandom = arrays.SelectName();

            Console.WriteLine($"Nummer {arrays.firstArray[gotTheRandom]} på listen over navne hedder {arrays.secondArray[gotTheRandom]}");
            Console.ReadKey();

            //);
            //Console.ReadKey();
        }
    }
}


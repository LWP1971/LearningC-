using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        List<string> fruits = new List<string>()
{
    "Apple",
    "Orange",
    "Banana",
    "Pineapple"
};

        fruits.Add("Mango");
        fruits.Remove("Orange");
            
    }
}

using System;
namespace TestOfArrays
{
    public class Arrays
    {
        public int GetTheRandom { get; set; }

        public int[] firstArray =
        {1,2,3,4,5};

        public string[] secondArray =
        {"Arne","Bjarne","Christian","Dennis","Erik"};

        public Random i = new Random();

        public int SelectName()
        {
            int a = i.Next (1 ,firstArray.Length);
            return a;
        }
    }
}

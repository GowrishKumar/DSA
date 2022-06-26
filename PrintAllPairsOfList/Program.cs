using System;

namespace PrintAllPairsOfList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int []{1, 2, 3, 4, 5};
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    Console.WriteLine($"{input[i]}, {input[j]}");
                }
            }
        }
    }
}

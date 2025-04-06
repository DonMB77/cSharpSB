using System;

namespace cSharpSB.old
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int[,] numbers = { { 1, 2, 3 },{ 1, 2, 3} };
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i,j]);
                }
            }
        }
    }
}
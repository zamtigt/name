using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            for (int y = 0; y < number; y += 2)
            {
                for(int x = 0; x < y/2; x++)
                {
                    Console.Write(".");
                }

                for (int x = 0; x < (number+1)-(y+1)-1; x++)
                {
                    Console.Write("*");
                }
                Console.Write("$");
                Console.WriteLine();
            }
        }
    }
}

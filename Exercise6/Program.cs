using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            PrintDiamond(row);
        }

        private static void PrintDiamond(int x)
        {
            {
                int i, j;
                for (i = 0; i <= x; i++)
                {
                    for (j = 1; j <= x - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
                for (i = x - 1; i >= 1; i--)
                {
                    for (j = 1; j <= x - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }
        }
    }
}

using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int x = Convert.ToInt32(Console.ReadLine());
            BinaryTriangle(x);
        }

        private static void BinaryTriangle(int x)
        {
            int lastValue = 0;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (lastValue == 1)
                    {
                        Console.Write("0");
                        lastValue = 0;
                    }
                    else if (lastValue == 0)
                    {
                        Console.Write("1");
                        lastValue = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
    

using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Range(x, y);
        }

        public static void Range(int val1, int val2)
        {
            for (int i = val1; i <= val2; i++)
            {
                int val = i, armstrongNumber = 0;
                while (val > 0)
                {
                    armstrongNumber += Convert.ToInt32(Math.Pow((val % 10), 3));
                    val /= 10;
                }
                if (armstrongNumber == i)
                    Console.WriteLine(i);
            }
        }
    }
}

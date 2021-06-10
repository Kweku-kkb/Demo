using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic operation = new Arithmetic();
            operation.Compute();

        }
    }

    class Arithmetic
    {
        int a, b;

        public int Addition()
        {
            int sum = a + b;
            return sum;
            
        }

        public int Subtraction()
        {
            int remainder = a - b;
            return remainder;
        }

        public int Division()
        {
            int divide = a / b;
            return divide;
        }

        public int Multiplication()
        {
            int multiply = a * b;
            return multiply;
        }

        public void Compute()
        {
            Console.Write("Enter value a: ");
            a = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Enter value b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select 1-4 to perform operations on 'a' and 'b' is \n1.Addition \n2.Subtraction \n3.Division \n4.Multiplication");
            int calc = Convert.ToInt32(Console.ReadLine());
            switch(calc)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {Addition()}");
                    break;
                case 2:
                    Console.WriteLine($"{a} - {b} = {Subtraction()}");
                    break;
                case 3:
                    Console.WriteLine($"{a} / {b} = {Division()}");
                    break;
                case 4:
                    Console.WriteLine($"{a} * {b} = {Multiplication()}");
                    break;
                default:
                    Console.WriteLine("No calculation");
                    break;
            }
        }
    }

   
}

using System;

namespace ConsoleApp1
{
    public class Program
    {
        // Вычисление факториала
        public static int Factorial(int n)
        {
            if (n == 0) 
                return 1;

            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(7));

            Console.ReadLine();
        }
    }
}
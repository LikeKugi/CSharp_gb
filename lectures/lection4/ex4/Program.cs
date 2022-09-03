using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            for (int i = 1; i < 40; i++)
            {
                Console.WriteLine("Fibbonacci({0}) = {1}", i, Fibbonacci(i));
            }

            for (int i = 1; i < 47; i++)
            {
                Console.WriteLine("Fibbonacci({0}) = {1}", i, dFibbonacci(i));
            }

        }

        static int Fibbonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1; 
            else
                return (Fibbonacci(n - 1) + Fibbonacci(n - 2));
        }

        static int dFibbonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1; 
            else
                return (dFibbonacci(n - 1) + dFibbonacci(n - 2));
        }
    }
}
using System;

namespace MyProgram
{
    class Program
    {
        /*
        * Напишите программу, которая на вход принимает 
        * два числа и выдаёт, какое число большее, а какое меньшее.
        */
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static void GetBigger(int x1, int x2)
        {
            if (x1 == x2)
            {
                Console.WriteLine("{0} equals {1}", x1, x2);
            }
            else if (x1 > x2)
            {
                Console.WriteLine("{0} > {1}", x1, x2);
            }
            else
                Console.WriteLine("{0} < {1}", x1, x2);
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            Console.WriteLine("which number is bigger");
            Console.WriteLine("Input number 1: ");
            int num1 = GetNumber();
            Console.WriteLine("Input number 2: ");
            int num2 = GetNumber();
            GetBigger(num1, num2);
        }
    }
}
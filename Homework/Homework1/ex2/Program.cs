using System;

namespace MyProgram
{
    class Program
    {
        /*
        * Напишите программу, которая принимает на вход 
        * три числа и выдаёт максимальное из этих чисел.
        */
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int GetMax(int x1, int x2, int x3)
        {
            int max = x1;
            if (x2 > max)
                max = x2;
            if (x3 > max)
                max = x3;
            return max;
        } 
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("Get max of 3 numbers");
            Console.WriteLine("input 1 number: ");
            int num1 = GetNumber();
            Console.WriteLine("input 2 number: ");
            int num2 = GetNumber();
            Console.WriteLine("input 3 number: ");
            int num3 = GetNumber();
            int max = GetMax(num1, num2, num3);
            Console.WriteLine("max number of {0}, {1}, {2} is {3}",num1, num2, num3, max);
        }
    }
}
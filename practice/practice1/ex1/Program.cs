using System;

namespace MyProgram
{
    class Program
    {
        /* 
        * Напишите программу, которая на вход принимает 
        * два числа и проверяет, является ли первое 
        * число квадратом второго.
        */
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            Console.WriteLine("input 1 number: ");
            int num1 = GetNumber();
            Console.WriteLine("inpt 2 number: ");
            int num2 = GetNumber();

            if (num1 == num2 * num2)
                Console.WriteLine("{0}^2 = {1}", num2, num1);
            else
                Console.WriteLine("not a pow");

        }
    }
}
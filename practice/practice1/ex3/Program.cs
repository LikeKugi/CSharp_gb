using System;

namespace MyProgram
{
    class Program
    {
        /* 
        * Напишите программу, которая принимает 
        * на вход трёхзначное число и на выходе 
        * показывает последнюю цифру этого числа.
        */
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static void Main(string[] args)
        {

        // Main starts here
            Console.Clear();
            Console.WriteLine("input number: ");

            int number = GetNumber();
            int result = number / 10;
            Console.WriteLine(result);

        }
    }
}
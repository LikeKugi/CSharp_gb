using System;

namespace MyProgram
{
    class Program
    {
        /* 
        * Напишите программу, которая принимает на вход 
        * трёхзначное число и на выходе показывает 
        * вторую цифру этого числа.
        */
        
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int FindSecondNumber(int n) => (n/10)%10;
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("Find 2nd digit of input value");
            Console.Write("input value: ");
            Console.WriteLine("2d digit is {0}",FindSecondNumber(GetNumber()));

        }
    }
}
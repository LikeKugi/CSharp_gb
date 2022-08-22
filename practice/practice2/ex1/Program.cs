using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => new Random().Next(100,1000);
        static int GetFinalNumber(int number)
        {
            Console.WriteLine(number);
            int ed = number % 10;
            int hundreds = number / 100;
            return (hundreds*10+ed);
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine(GetFinalNumber(GetNumber()));

        }
    }
}
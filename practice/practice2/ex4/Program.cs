using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static void CheckForPow(int first, int second)
        {
            bool a = (first * first == second);
            bool b = (second * second == first);

            if (a)
                Console.WriteLine("{0}^2 = {1}", first, second);
            else if (b)
                Console.WriteLine("{0}^2 = {1}", second, first);
                else
                    Console.WriteLine("not a power");
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            Console.WriteLine("input first number:");
            int firstNumber = GetNumber();
            Console.WriteLine("input second number:");
            int secondNumber = GetNumber();
            CheckForPow(firstNumber,secondNumber);

        }
    }
}
using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int FindThirdDigit(int n) => (n>=100) ? (n/100%10) : -1;
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("Find 3rd digit of number");
            Console.Write("input number: ");
            var number = FindThirdDigit(GetNumber());

            if (number != -1)
                Console.WriteLine(number);
            else
                Console.WriteLine("третьей цифры нет");

        }
    }
}
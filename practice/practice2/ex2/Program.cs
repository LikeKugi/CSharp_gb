using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static void CheckPow(int a, int b)
        {
            int bPow = (b % a);
            if (bPow == 0)
                Console.WriteLine("{0} % {1} = {2}", b, a, bPow);
            else Console.WriteLine(b % a);
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            Console.WriteLine("input first number:");
            int a = GetNumber();
            Console.WriteLine("input second number:");
            int b = GetNumber();
            CheckPow(a, b);
        }
    }
}
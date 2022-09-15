using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            Console.WriteLine("enter A: ");
            var A = GetIntNumber();
            Console.WriteLine("enter B: ");
            var B = GetIntNumber();
            Console.WriteLine("{0}", GetPower(A, B));


        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
        static double GetPower(int A, int B)
        {
            if (B >= 1) return GetPower(A, B - 1) * A;
            if (B <= -1) return GetPower(A, B + 1) / A;
            return 1.0;
        }
    }
}
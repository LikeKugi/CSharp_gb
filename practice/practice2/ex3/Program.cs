using System;

namespace MyProgram
{
    class Program
    {
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static bool CheckDividers (int a, int b, int num)
        {
            bool aCheck = (num % a == 0);
            bool bCheck = (num % b == 0);
            return (aCheck && bCheck);
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("input first divider: ");
            int a = GetNumber();
            Console.WriteLine("input second divider: ");
            int b = GetNumber();
            Console.WriteLine("input number to check for dividers: ");
            int number = GetNumber();

            if (CheckDividers(a,b,number))
                Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
        }
    }
}
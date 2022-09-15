using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var n = GetIntNumber();
            ShowNumbers(n);
            Console.WriteLine();
            Console.WriteLine(FindSum(5734));

        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
        static void ShowNumbers(int n)
        {
            if (n>1)
                ShowNumbers(n-1);

            Console.Write("{0,4}",n);
        }
        static int FindSum(int n)
        {
            if (n>0) return FindSum(n/10) + n%10;
            return 0;
        }
    }
}
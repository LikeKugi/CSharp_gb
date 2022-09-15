using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("enter M: ");
            var M = GetIntNumber();
            Console.WriteLine("enter N: ");
            var N = GetIntNumber();
            ShowNumbers(Math.Min(M,N),Math.Max(M,N));


        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());

        static void ShowNumbers(int m,  int n)
        {
            if (n>m)
                ShowNumbers(m, n-1);

            Console.Write("{0,4}",n);
        }
    }
}
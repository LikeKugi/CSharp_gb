using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var number = GetNumber();
            Console.WriteLine(FindSum(number));

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int FindSum(int n) => Enumerable.Range(1,n).Aggregate(0,(a,n)=>a+=n);
    }
}
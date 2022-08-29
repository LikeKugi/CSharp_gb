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

            Console.WriteLine("{0}! = {1}",number,FindFctorize(number));

        }

        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static int FindFctorize(int n) => Enumerable.Range(1,n).Aggregate(1,(a,n)=>a*=n);
    }
}
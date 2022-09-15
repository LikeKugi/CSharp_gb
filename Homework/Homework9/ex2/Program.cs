using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.Write("enter start of range: ");
            var M = GetIntnumber();
            Console.Write("enter end of range: ");
            var N = GetIntnumber();
            var sum = FindSumOfRange(Math.Min(M,N),Math.Max(M,N));
            Console.WriteLine("Sum of numbers in range = {0}",sum);

            var recursiveSum = FindRecursive(Math.Min(M,N),Math.Max(M,N));
            Console.WriteLine("Recursive sum is {0}", recursiveSum);

        }
        static int GetIntnumber() => Convert.ToInt32(Console.ReadLine());
        static int FindRecursive(int start, int end)
        {
            if (end >= start) return (FindRecursive(start,end-1)+end);
            return 0;
        }
        static int FindSumOfRange(int start, int end) => Enumerable
                                                                .Range(start,Math.Abs(end-start+1))
                                                                .Aggregate(0,(a,x)=>a+=x);

    }
}
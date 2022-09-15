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
            Console.Write("Enter start of range: ");
            var M = GetIntNumber();
            Console.Write("Enter end of range: ");
            var N = GetIntNumber();
            var numbers = CreateRange(M,N);
            PrintRange(numbers);
            Console.WriteLine();
            PrintRecursive(M,N);
        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] CreateRange(int start, int end) => Enumerable.Range(start,end-start+1).Select(n=>n).ToArray();
        static void PrintRange(int[] numbers) => Console.WriteLine(string.Join(" ",numbers)); 
        static void PrintRecursive(int start, int end)
        {
            if (end > start) PrintRecursive( start, end-1);
            Console.Write("{0,3}",end);
        }
    }
}
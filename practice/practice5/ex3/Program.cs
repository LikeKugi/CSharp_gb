using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("enter length of an array: ");
            var len = GetNumber();
            Console.WriteLine("enter min value: ");
            var min = GetNumber();
            Console.WriteLine("enter max value: ");
            var max = GetNumber();
            var numbers = CreateArray(len,min,max);
            PrintArray(numbers);

            Console.WriteLine("enter min value of range: ");
            var minRange = GetNumber();
            Console.WriteLine("enter max value of range: ");
            var maxRange = GetNumber();

            var counter = CountRange(numbers,minRange,maxRange);
            Console.WriteLine("in this array {0} elements in range [{1},{2}]",counter,minRange,maxRange);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min, max + 1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine(string.Join(" ", numbers.Select(x => x)));
        static int CountRange(int[]numbers, int min, int max) => numbers.Aggregate(0, (a,x)=> a+=(x>=min&&x<=max)?1:0);
        
    }
}
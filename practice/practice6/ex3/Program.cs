using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("input 3 numbers with spaces");
            var numbers = GetNumbers();
            FindTriangle(numbers);
        }
        static int[] GetNumbers() => Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        static void FindTriangle(int[]coords) => Console.WriteLine(coords.Aggregate(0,(a,x)=>a+=x)-coords.Max()>coords.Max()?"yes":"no");
    }
}
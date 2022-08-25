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
            Console.WriteLine("Print cubes until number");
            Console.WriteLine("input number: ");
            var value = GetNumber();
            FindCubes(value);
        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static void FindCubes(int n) => Console.WriteLine(string.Join(" ",Enumerable.Range(1,n).Select(x=>Math.Pow(x,3))));
    }
}
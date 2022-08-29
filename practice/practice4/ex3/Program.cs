using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var numbers = FullArr();

            PrintArray(numbers);

        }

        static Random rd => new Random();
        static int[] FullArr() => Enumerable.Range(1,8).Select(n=>rd.Next(0,2)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine("[ " + string.Join(",", numbers.Select(n => n)) + " ]");
    }
}
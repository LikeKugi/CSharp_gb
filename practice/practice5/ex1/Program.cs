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
            var changedNumbers = ChangeSign(numbers);
            PrintArray(changedNumbers);


        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min, max + 1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine(string.Join(" ", numbers.Select(x => x)));
        static int[] ChangeSign(int[]num) => num.Select(x=>-x).ToArray();
    }
}
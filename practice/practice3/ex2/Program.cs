using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine("print squares until number");
            Console.WriteLine("input number");
            var number = GetNumber();

            PrintSq(number);

        }

        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static void PrintSq(int n) => Console.WriteLine(string.Join(" ",Enumerable.Range(1,n).Select(x=>x*x)));
    }
}
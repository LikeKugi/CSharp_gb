using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("1 of fibbonacci");
            var a = GetNumber();
            Console.WriteLine("2 of fibbonacci");
            var b = GetNumber();
            Console.WriteLine("length:");
            var m = GetNumber();

            var numbers = FindFibbonacci(a,b,m);
            PrintArray(numbers);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static void PrintArray(int[] arr) => Console.WriteLine(string.Join(" ", arr.Select(x=>x)));

        static int[] FindFibbonacci (int a, int b, int len)
        {
            var numbers = new int[len];
            numbers[0] = a;
            numbers[1] = b;
            for (int i = 2;i<len;i++)
            {
                numbers[i] = numbers[i-1] + numbers[i-2];
            }
            return numbers;
        }
        
    }
}
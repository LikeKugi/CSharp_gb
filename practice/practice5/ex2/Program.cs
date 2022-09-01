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

            Console.WriteLine("enter value to find:");
            var findingValue = GetNumber();

            if (FindNumber(numbers,findingValue))
                Console.WriteLine("yes");
                else
                Console.WriteLine("no");

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min, max + 1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine(string.Join(" ", numbers.Select(x => x)));
        static bool FindNumber(int[]arr,int num)
        {
            foreach (int number in arr)
            {
                if (number==num)
                    return true;
            }
            return false;
        }
    }
}
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

            PrintArray(CreatePairs(numbers));
        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min, max + 1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine(string.Join(" ", numbers.Select(x => x)));

        static int[] CreatePairs(int[]numbers)
        {
            var len = (numbers.Length%2==0)?(numbers.Length/2):(numbers.Length/2+1);
            var newNumbers = new int[len];

            for (int i = 0; i<len;i++)
            {
                newNumbers[i] = numbers[i]*numbers[numbers.Length-1-i];
            }
            return newNumbers;

            
        }
    }
}
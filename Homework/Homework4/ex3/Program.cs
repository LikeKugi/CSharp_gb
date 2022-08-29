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
            Console.WriteLine("an array of 8 random numbers");
            var rndArr = Numbers();
            PrintArray(rndArr);
            Console.WriteLine();

            Console.WriteLine("an array of 8 random numbers that can be negative");
            var rndNegArr = NumbersNeg();
            PrintArray(rndNegArr);
            Console.WriteLine();

            Console.WriteLine("an array of 8 input numbers");
            Console.WriteLine("input 8 numbers");
            var inpArr = InputNumbers();
            PrintArray(inpArr);
            Console.WriteLine();

            Console.WriteLine("an array of 8 input numbers");
            Console.WriteLine("input 8 numbers in line with spaces between numbers");
            var inpLineArr = InputLineNumbers();
            PrintArray(inpLineArr);
            Console.WriteLine();

            Console.WriteLine("another way of array:");
            Console.WriteLine("input length of an array:");
            var len = GetNumbers();
            Console.WriteLine("Let's full the array");
            var numbers = ManualFilling(len);
            PrintArray(numbers);
            Console.WriteLine();

        }
        static Random rd => new Random();
        static int GetNumbers() => Convert.ToInt32(Console.ReadLine());
        static int[] Numbers() => Enumerable.Range(1, 8).Select(n => rd.Next(1, 50)).ToArray();
        static int[] NumbersNeg() => Enumerable.Range(1, 8).Select(n => rd.Next(1, 50) * (rd.Next(1, 3) == 1 ? 1 : -1)).ToArray();
        static int[] InputNumbers() => Enumerable.Range(1, 8).Select(n => Convert.ToInt32(Console.ReadLine())).ToArray();
        static int[] InputLineNumbers() => Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        static int[] ManualFilling(int len)
        {
            var numbers = new int[len];
            for (int i = 0; i<len;i++)
            {
                Console.Write("input {0} element :",i);
                numbers[i] = GetNumbers();
            }
            return numbers;
        }

        static void PrintArray(int[] numbers) => Console.WriteLine("[ " + string.Join(",", numbers.Select(n => n)) + " ]");
    }
}
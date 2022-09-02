using System;

namespace MyProgram
{
    class Program
    {
        /*
        * Задайте массив вещественных чисел. 
        * Найдите разницу между максимальным 
        * и минимальным элементов массива.
        */
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.Clear();
            Console.WriteLine("enter length of an array: ");
            var len = GetNumber();
            Console.WriteLine("enter min value: ");
            var minValue = GetNumber();
            Console.WriteLine("enter max value: ");
            var maxValue = GetNumber();
            var numbers = CreateArray(len,minValue,maxValue);
            PrintArray(numbers);
            var min = FindMinElement(numbers);
            var max = FindMaxElement(numbers);
            PrintDiffMaxMin(min,max);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min, max + 1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine(string.Join(" ", numbers.Select(x => x)));
        static int FindMinElement(int[] numbers) => numbers.Aggregate(int.MaxValue,(a,x)=>(x<a)?x:a);
        static int FindMaxElement(int[] numbers) => numbers.Aggregate(int.MinValue,(a,x)=>(x>a)?x:a);
        static void PrintDiffMaxMin(int min, int max) => Console.WriteLine("{0} - {1} = {2}",max,min,max-min);
    }
}
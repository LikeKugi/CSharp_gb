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
        static double[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min, max + 1)+rd.NextDouble()).ToArray();
        static void PrintArray(double[] numbers) => Console.WriteLine(string.Join(" ", numbers.Select(x => Math.Round(x,2))));
        static double FindMinElement(double[] numbers) => numbers.Aggregate(Double.PositiveInfinity,(a,x)=>(x<a)?x:a);
        static double FindMaxElement(double[] numbers) => numbers.Aggregate(Double.NegativeInfinity,(a,x)=>(x>a)?x:a);
        static void PrintDiffMaxMin(double min, double max) => Console.WriteLine("{0:n2} - {1:n2} = {2:n2}",max,min,max-min);
    }
}
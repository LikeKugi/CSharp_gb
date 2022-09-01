using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("input size of array:");
            var size = GetNumber();
            Console.WriteLine("input min value:");
            var minValue = GetNumber();
            Console.WriteLine("input max value:");
            var maxValue = GetNumber();

            var numbers = CreateRandomArray(size, minValue,maxValue);
            PrintArray(numbers);

            Console.WriteLine("this array has {0} negative numbers", FindSumNegative(numbers));

        }
        static Random rd => new Random();
        static int GetNumber()=> Convert.ToInt32(Console.ReadLine());
        static int[] CreateRandomArray(int size, int minValue,int maxValue) => Enumerable.Range(minValue,maxValue-minValue).Select(n=>rd.Next(minValue,maxValue+1)).ToArray();
        static void PrintArray(int[]arr) => Console.WriteLine(string.Join(" ",arr.Select(x=>x)));
        static int FindSumNegative(int[] n) => n.Aggregate(0,(a,n) => a+= (n<0)?1:0);
    }
}
using System;

namespace MyProgram
{
    class Program
    {
        /*
        * Задайте массив заполненный случайными 
        * положительными трёхзначными числами. 
        * Напишите программу, которая покажет 
        * количество чётных чисел в массиве.
        */
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.Write("input length of an array: ");
            var len = GetNumber();
            var numbers = FillingArray(len);
            PrintArray(numbers);
            var counterEven = CountEven(numbers);
            Console.WriteLine("this array has {0} even numbers",counterEven);
            

        }
        static Random rd => new Random();
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] FillingArray(int len) => Enumerable.Range(1,len).Select(n=>n=rd.Next(100,1000)).ToArray();
        static void PrintArray(int[]arr) => Console.WriteLine(string.Join(" ",arr.Select(n=>n)));
        static int CountEven(int[]arr) => arr.Aggregate(0,(a,x)=>a+=(x%2==1)?1:0);

    }
}
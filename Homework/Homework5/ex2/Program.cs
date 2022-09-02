using System;

namespace MyProgram
{
    class Program
    {
        /*
        * Задайте одномерный массив, 
        * заполненный случайными числами. 
        * Найдите сумму элементов, стоящих на нечётных позициях.
        */
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("enter length of an array: ");
            var len = GetNumber();
            var rndArray = FillingArray(len);
            PrintArray(rndArray);
            var sum = SumOfElementsOddInd(rndArray);
            Console.WriteLine("sum of elements with odd indexes is: {0}",sum);

        }

        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd = new Random();
        static int[] FillingArray(int len) => Enumerable.Range(1,len).Select(n=>rd.Next(-50,50)).ToArray();
        static void PrintArray(int[] arr) => Console.WriteLine(string.Join(" ",arr.Select(n=>n)));
        static int SumOfElementsOddInd(int[]arr)
        {
            var elementsSum = 0;
            for (int i = 0;i<arr.Length;i++)
            {
                if (i%2!=0)
                    elementsSum+=arr[i];
            }
            return elementsSum;
        }

    }
}
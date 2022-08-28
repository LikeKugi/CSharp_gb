using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var arr = new int[] { 1, 2, 5, 4, 3, 2, 6, 7, 1, 10 };

            PrintArray(arr);

            PrintArray(SelectionSort(arr));
        }
        static void PrintArray(int[] arr) => Console.WriteLine(string.Join(" ", arr.Select(x => x)));

        static int[] SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minPosition = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minPosition])
                        minPosition = j;
                }

                int temp = numbers[i];
                numbers[i] = numbers[minPosition];
                numbers[minPosition] = temp;
            }
            return numbers;
        }
    }
}
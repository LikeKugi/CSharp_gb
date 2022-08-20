using System;

namespace MyProgram
{
    class Program
    {
        static void FillArray(int[] collection)
        {
            int length = collection.Length;
            int index = 0;
            while (index < length)
            {
                collection[index] = new Random().Next(1, 10);
                index++;
            }
        }
        static void PrintArray(int[] printingArray)
        {
            foreach (int number in printingArray)
            {
                Console.Write(number + " ");
            }
        }
        static int IndexOf(int[]numbers, out int find)
        {
            find = 4;
            int count = numbers.Length;
            int index = 0;
            int position = -2;
            while(index<count)
            {
                if (numbers[index]==find)
                {
                    position = index;
                    
                }
                index++;
            }
            Console.WriteLine(position);
            return position;
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var array = new int[10];
            
            FillArray(array);
            PrintArray(array);
            IndexOf(array, out int find);

        }
    }
}
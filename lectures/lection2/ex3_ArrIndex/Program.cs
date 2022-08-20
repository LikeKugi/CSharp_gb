using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var array = new int[] { 1, 12, 31, 4, 15, 16, 17, 18 };

            int n = array.Length;
            int find = 15;

            int index = 0;

            while (index < n)
            {
                if (array[index] == find)
                {
                    Console.WriteLine(index);

                }
                index++;
            }

        }
    }
}
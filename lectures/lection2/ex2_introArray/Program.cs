using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            int[] array = {11, 12, 13, 14, 15, 16, 17, 18, 19};
            array[0] = 12;
            Console.WriteLine(array[0]);

            int max = array[0];
            foreach (int number in array)
                if (number > max) 
                    max = number;
            Console.WriteLine(max);

        }
    }
}
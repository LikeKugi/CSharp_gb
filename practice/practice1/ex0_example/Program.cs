using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            Console.Write("input number: ");
            //int number = int.Parse(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}^2 = {1}", number, GetPow(number));
        }

        static int GetPow(int number) => number * number;
    }
}
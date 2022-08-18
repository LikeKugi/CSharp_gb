using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        /*
        * Напишите программу, которая на вход 
        * принимает одно число (N), а на выходе 
        * показывает все целые числа в промежутке от -N до N.
        */
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] GetRange(int n) => Enumerable.Range(0,2*n+1).Select(x => x-n).ToArray();
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("Input number: ");
            int value = GetNumber();
            var numbers = GetRange(value);
            foreach (int number in numbers)
                Console.Write("{0} ",number);
        }
    }
}
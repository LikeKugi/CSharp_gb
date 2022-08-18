using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        /* Напишите программу, которая на вход 
        * принимает число (N), а на выходе показывает 
        * все чётные числа от 1 до N.
        */

        static int[] GetRange(int n) => Enumerable.Range(1,n).Where(x => x%2==0).ToArray();
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("print even numbers less then number");
            Console.Write("input number: ");
            int value = GetNumber();

            var numbers = GetRange(value);
            foreach (int number in numbers)
                Console.Write("{0} ",number);

        }
    }
}
using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        /*
        * Пользователь вводит с клавиатуры M чисел.
        * Посчитайте, сколько чисел больше 0 ввёл пользователь.
        */
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.Write("how many numbers will input? ");
            var len = GetNumber();
            
            var numbers = CreateArray(len);
            PrintArray(numbers);

            var positives = CountPositive(numbers);
            Console.WriteLine("You entered {0} positive numbers",positives);


        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] CreateArray(int len)
        {
            var numbers = new int[len];
            for (int i = 0; i< len; i++)
            {
                Console.Write("Enter {0} number: ", i+1);
                numbers[i] = GetNumber();
            }
            return numbers;
        }
        static int CountPositive(int[]numbers) => numbers.Aggregate(0,(a,x)=>a+=(x>0)?1:0);
        static void PrintArray(int[] numbers) => Console.WriteLine(string.Join(" ", numbers.Select(x => x)));
    }
}
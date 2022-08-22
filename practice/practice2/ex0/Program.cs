using System;

namespace MyProgram
{
    class Program
    {
        /*
        * Напишите программу, которая выводит 
        * случайное число из отрезка [10, 99] и 
        * показывает наибольшую цифру числа.
        */
        static int GetNumber() => new Random().Next(10,100);
        static int FindBiggerNumber(int number)
        {
            Console.WriteLine(number);
            int ed = number % 10;
            int dec = number / 10;
            return (ed > dec) ? ed : dec;

        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            
            Console.WriteLine("Find bigger digit of random number");
            Console.Write("Number is: ");
            Console.WriteLine("Bigger digit is {0} ",FindBiggerNumber(GetNumber()));

        }
    }
}
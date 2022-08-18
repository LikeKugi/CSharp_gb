using System;

namespace MyProgram
{
    class Program
    {
        /*
        *Напишите программу, которая на вход 
        * принимает число и выдаёт, является 
        * ли число чётным 
        * (делится ли оно на два без остатка).
        */
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static bool OddOrEven(int n) => (n % 2 == 0) ? true : false;

        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            Console.WriteLine("Odd or Even");
            Console.Write("input number: ");
            int number = GetNumber();
            if (OddOrEven(number))
                Console.WriteLine("{0} is Even", number);
            else
                Console.WriteLine("{0} is Odd", number);

        }
    }
}
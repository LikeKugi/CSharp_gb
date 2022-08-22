using System;

namespace MyProgram
{
    class Program
    {
        /* 
        * Напишите программу, которая принимает 
        * на вход цифру, обозначающую день недели, 
        * и проверяет, является ли этот день выходным.
        */
        static int GetDay() => Convert.ToInt32(Console.ReadLine());
        static void CheckDay(int inptDay)
        {
            inptDay %= 7;
            Days day = (Days)inptDay;
            if ((int)day % 6 == 0 || (int)day % 7 == 0)
                Console.WriteLine("{0} is a weekend", day);
                else
                    Console.WriteLine("{0} is a weekday", day);
        }
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.WriteLine("Check day of week is it weekend or weekday");
            Console.WriteLine("enter number to check day: ");
            var inptDay = GetDay();
            CheckDay(inptDay);
            
        }
    }
    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
}
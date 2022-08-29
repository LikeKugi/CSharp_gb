using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            Console.WriteLine("input number: ");
            var number = GetNumber();

            Console.WriteLine("sum of digits in number: {0}", FindSumDigits(number));
            Console.WriteLine();
            Console.WriteLine("Немножко вандализма:");
            Console.WriteLine(SumDigits(number));

        }

        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static int FindSumDigits(int n)
        {
            var accum = 0;
            while (n > 9)
            {
                accum += n % 10;
                n /= 10;
            }
            accum += n;
            return accum;
        }

        // извините, но этот вандализм того стоит :)
        static int SumDigits(int num) => num.ToString().ToCharArray().Aggregate(0, (a, n) => a += Convert.ToInt32(n - '0'));
    }
}
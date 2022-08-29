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
            Console.WriteLine("input power: ");
            var power = GetNumber();
            Console.WriteLine("{0}^{1} = {2}", number, power, FindPower(number,power));
        }

        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static int FindPower(int n, int pow)
        {
            var answer = 1;
            for (int i = 0; i< pow; i++)
                answer *= n;
            return answer;
        }
    }
}
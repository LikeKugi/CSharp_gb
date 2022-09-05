using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var number = GetNumber();
            var str = ConvertNumber(number);

            Console.WriteLine(str);
        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static string ConvertNumber(int number)
        {
            var result = string.Empty;
            while (number >= 2)
            {
                var mod = number % 2;
                number /= 2;
                
                result = string.Concat(mod,result);
                Console.WriteLine(result);
            }
            result = string.Concat(number,result);
            return result;
        }
    }
}
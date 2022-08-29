using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine("input number");
            var number = GetNumber();
            Console.WriteLine("in {0} are {1} digits",number, Findlength(number));

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int Findlength(int n) => n.ToString().Length;
    }
}
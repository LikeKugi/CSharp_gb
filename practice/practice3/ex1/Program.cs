using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var quarter = GetQuarter();
            FindCoords(quarter);

        }

        static byte GetQuarter() => Convert.ToByte(Console.ReadLine());

        static void FindCoords(byte a)
        {
            Console.WriteLine((a == 1) ? "x>0;y>0" : (a == 2) ? "x<0;y>0" : (a == 3) ? "x<0,y<0" : (a == 4) ? "x>0,y<0" : "0");
        }
    }
}
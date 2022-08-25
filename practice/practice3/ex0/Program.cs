using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var x = GetCoords();
            var y = GetCoords();

            Console.WriteLine(FindQuorter(x,y));
            

        }

        static double GetCoords() => Convert.ToDouble(Console.ReadLine());

        static byte FindQuorter(double x, double y)
        {
            if (x > 0 && y > 0)
                return 1;
            if (x < 0 && y > 0)
                return 2;
            if (x < 0 && y < 0)
                return 3;
            if (x > 0 && y < 0)
                return 4;
            return 0;
        }
    }
}
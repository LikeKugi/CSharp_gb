using System;

namespace MyProgram
{
    class Program
    {
        static int FindMax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            int a1 = 15;
            int b1 = 21;
            int c1 = 39;
            int a2 = 12;
            int b2 = 22;
            int c2 = 32;
            int a3 = 13;
            int b3 = 23;
            int c3 = 33;

            int max = a1;

            if (b1 > max) max = b1;
            if (c1 > max) max = c1;

            if (a2 > max) max = a2;
            if (b2 > max) max = b2;
            if (c2 > max) max = c2;

            if (a3 > max) max = a3;
            if (b3 > max) max = b3;
            if (c3 > max) max = c3;

            int max1 = FindMax(a1, b1, c1);
            int max2 = FindMax(a2, b2, c2);
            int max3 = FindMax(a3, b3, c3);
            int max_of = FindMax(max1, max2, max3);

            Console.WriteLine(max_of);

            int max_func = FindMax(FindMax(a1, b1, c1), FindMax(a2, b2, c2), FindMax(a3, b3, c3));
            Console.WriteLine(max_func);
        }
    }
}
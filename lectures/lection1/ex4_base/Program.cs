using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            int a = 1;
            int b = 2;
            int c = 6;
            int d = 8;
            int e = 4;

            int max = a;
            if(b > max)
                max = b;
            if (c > max)
                max = c;
            if (d > max)
                max = d;
            if (e > max)
                max = e;
            
            Console.WriteLine(max);
        }
    }
}
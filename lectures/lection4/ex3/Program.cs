using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var fc = Factorize(19); // max of integer
            Console.WriteLine("{0}",fc);

            for (int i= 1; i<30; i++)
            {
                Console.WriteLine("{0}! = {1}",i,Factorize(i));
            }
            Console.WriteLine();
            for (int i= 1; i<30; i++)
            {
                Console.WriteLine("{0}! = {1}",i,dFactorize(i));
            }

        }

        static int Factorize(int n)
        {
            if (n<=1)
            {
                return n;
            }
            else
            {
                return n*Factorize(n-1);
            }
        }

        static double dFactorize(int n)
        {
            if (n<=1)
            {
                return n;
            }
            else
            {
                return n*dFactorize(n-1);
            }
        }
    }
}
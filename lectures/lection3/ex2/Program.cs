using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            for (int i = 2; i<=10;i++)
            {
                for (int j = 2; j<=10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}",i,j,i*j);
                }
                Console.WriteLine();
            }

        }
    }
}
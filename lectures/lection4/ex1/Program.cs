using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            StringMatrix();
            Console.WriteLine();
            var matrix = new int [3,4];
            PrintArray(matrix);
            Console.WriteLine();
            FillArray(matrix);
            PrintArray(matrix);
        }
        static void StringMatrix()
        {
            var table = new string[2,5];
            
            table[1,2] = "word";

            for (int rows = 0; rows<2;rows++)
            {
                for (int columns=0; columns<5;columns++)
                {
                    Console.Write("{0}", table[rows,columns]);
                }
                Console.WriteLine();
            }
        }
        static void FillArray(int[,] matr)
        {
            for (int i = 0; i<matr.GetLength(0);i++)
            {
                for (int j=0; j<matr.GetLength(1);j++)
                {
                    matr[i,j] = new Random().Next(1,10);
                }
                
            }
        }
        static void PrintArray(int[,]matr)
        {
            for (int i = 0; i<matr.GetLength(0);i++)
            {
                for (int j=0; j<matr.GetLength(1);j++)
                {
                    Console.Write("{0,4}", matr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
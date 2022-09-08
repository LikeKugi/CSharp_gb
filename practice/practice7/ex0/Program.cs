using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var a = new Matrix();
            a.PrintArray();

        }
    }
    class Matrix
    {
        public int Row { get; init; }
        public int Column { get; init; }
        public int[,] Data { get; init; }
        public Matrix()
        {
            Console.Write("input rows: ");
            this.Row = GetIntNumber();
            Console.Write("input columns: ");
            this.Column = GetIntNumber();
            Console.Write("input min value: ");
            var min = GetIntNumber();
            Console.Write("input max value: ");
            var max = GetIntNumber();
            this.Data = new int[Row, Column];
            FillRandomArray(min, max);
        }
        static Random rd => new Random();
        private int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
        private void FillRandomArray(int min, int max)
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    this.Data[i, j] = rd.Next(min, max);
                }
            }
        }
        public void PrintArray()
        {
            Console.WriteLine();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    Console.Write("{0,5}", Data[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
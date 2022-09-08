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
            a.MinSumOfRows();
            var b = Matrix.EvenIndexes(a);
            b.PrintArray();
            Console.WriteLine("sum of main diagonal {0}", a.SumOfMain());
            var c = new Matrix(true);
            c.PrintArray();

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
        public Matrix (bool check)
        {
            Console.Write("input rows: ");
            this.Row = GetIntNumber();
            Console.Write("input columns: ");
            this.Column = GetIntNumber();
            this.Data = new int[this.Row,this.Column];
            FillArrayOfSumIndexes();
        }
        public Matrix(Matrix a)
        {
            this.Row = a.Row;
            this.Column = a.Column;
            this.Data = new int[this.Row,this.Column];

            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                        this.Data[i, j] = (int)Math.Pow((a.Data[i, j]), 2);
                    else
                        this.Data[i, j] = a.Data[i, j];
                }
            }
        }
        public int SumOfMain()
        {
            var sum = 0;
            var len = Math.Min(this.Row,this.Column);
            for (int i = 0; i < len; i++)
            {
                sum += this.Data[i,i];
            }
            return sum;
        }
        public void MinSumOfRows()
        {
            var sumOfRows = new int[this.Row];
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    sumOfRows[i] += this.Data[i,j];
                }
            }
            Console.WriteLine("min sum of row {0}", 
                    Array.IndexOf(sumOfRows, FindMin(sumOfRows)));
        }
        private int FindMin(int[]numbers) => 
                    numbers.Aggregate(int.MinValue, (a,n) => a = (n>a)? n:a);
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
        private void FillArrayOfSumIndexes()
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    this.Data[i, j] = i + j;
                }
            }
        }
        public static Matrix EvenIndexes(Matrix a)
        {
            var b = new Matrix(a);
            return b;
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
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
            Matrix.PrintMatrix(a);
            var b = Matrix.TranspottingMatrix(a);
            Matrix.PrintMatrix(b);

        }
    }
    class Matrix
    {
        public int Row {get;init;}
        public int Column {get;init;}
        public int[,] Data {get; private set;}
        public Matrix()
        {
            Console.WriteLine("input rows: ");
            this.Row = GetIntNumber();
            Console.WriteLine("input columns: ");
            this.Column = GetIntNumber();
            this.Data = new int[this.Row,this.Column];
            FillingArray();
        }
        public Matrix (int row, int columns)
        {
            this.Row = row;
            this.Column = columns;
            this.Data = new int[this.Row,this.Column];
        }
        public static Matrix TranspottingMatrix(Matrix a)
        {
            var rows = a.Column;
            var columns = a.Row;
            var B = new Matrix(rows,columns);
            for (int i = 0;i<B.Row;i++)
            {
                for (int j = 0; j<B.Column; j++)
                {
                    B.Data[i,j] = a.Data[j,i];
                }
            }
            return B;
        }
        private void FillingArray()
        {
            for (int i = 0; i<this.Row;i++)
            {
                for (int j = 0; j< this.Column;j++)
                {
                    Data[i,j] = rd.Next(1,20);
                }
            }
        }
        public static void PrintMatrix(Matrix a)
        {
            Console.WriteLine();
            for (int i = 0; i<a.Row;i++)
            {
                for (int j = 0; j< a.Column;j++)
                {
                    Console.Write("{0,4}",a.Data[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
    }
}
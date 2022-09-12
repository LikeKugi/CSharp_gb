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
            var b = Matrix.DeleteRowColumn(a);
            Matrix.PrintMatrix(b);

        }
    }
    class Matrix
    {
        public int Row { get; init; }
        public int Column { get; init; }
        public int[,] Data { get; private set; }
        public Matrix()
        {
            Console.WriteLine("input rows: ");
            this.Row = GetIntNumber();
            Console.WriteLine("input columns: ");
            this.Column = GetIntNumber();
            this.Data = new int[this.Row, this.Column];
            FillingArray();
        }
        public Matrix(int row, int columns)
        {
            this.Row = row;
            this.Column = columns;
            this.Data = new int[this.Row, this.Column];
        }
        public int[] FindMin()
        {
            int minRow = 0;
            int minColumn = 0;
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    if (this.Data[i, j] < this.Data[minRow, minColumn])
                    {
                        minRow = i;
                        minColumn = j;
                    }
                }
            }
            Console.WriteLine("{0} ({1};{2})", this.Data[minRow, minColumn], minRow, minColumn);
            return new int[] { minRow, minColumn };

        }
        public static Matrix DeleteRowColumn(Matrix a)
        {
            var rows = a.Row-1;
            var columns = a.Column-1;
            var coordsDelete = a.FindMin();
            var rowDel = coordsDelete[0];
            var colDel = coordsDelete[1];
            var B = new Matrix(rows, columns);
            for (int i = 0, bRow = 0; i < a.Row; i++)
            {
                bRow = i;
                if (i >= rowDel) bRow = i-1;
                for (int j = 0, bCol = 0; j < a.Column; j++)
                {
                    bCol = j;
                    if (j >= colDel) bCol = j-1;
                    if (i!=rowDel&&j!=colDel)
                        B.Data[bRow,bCol] = a.Data[i,j];
                }
            }
            return B;
        }
        private void FillingArray()
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    Data[i, j] = rd.Next(1, 20);
                }
            }
        }
        public static void PrintMatrix(Matrix a)
        {
            Console.WriteLine();
            for (int i = 0; i < a.Row; i++)
            {
                for (int j = 0; j < a.Column; j++)
                {
                    Console.Write("{0,4}", a.Data[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
    }
}
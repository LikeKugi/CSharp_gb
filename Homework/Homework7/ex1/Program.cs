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
            a.FindElementByIndex();

            var b = new Matrix();
            Matrix.PrintMatrix(b);
            b.FindAverageColumns();

        }
    }
    class Matrix
    {
        public int Rows { get; init; }
        public int Columns { get; init; }
        public double[,] Data { get; init; }
        public int Type { get; init; } 
        // 1 - double
        // 2 - int
        public Matrix()
        {
            Console.Write("how many rows? ");
            this.Rows = GetIntNumber();
            Console.Write("How many columns? ");
            this.Columns = GetIntNumber();
            Console.Write("what is min value? ");
            var min = GetIntNumber();
            Console.Write("What is max value? ");
            var max = GetIntNumber();
            this.Data = new double[this.Rows, this.Columns];
            Console.WriteLine("Print 1 for double values or \n"
                            + "print 2 for int values "
                            + "of matrix ");
            this.Type = GetIntNumber();
            if (this.Type == 1) FillingDoubleMatrix(min, max);
            else if (this.Type == 2) FillingIntMatrix(min, max);
        }
        // заполнение матрицы случайными вещественными числами
        private void FillingDoubleMatrix(int min, int max)
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    this.Data[i, j] = rd.NextDouble() * (max - min) + min;
                }
            }
        }
        // заполнение матрицы случайными целыми числами
        private void FillingIntMatrix(int min, int max)
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    this.Data[i, j] = rd.Next(min, max + 1);
                }
            }
        }
        // поиск элемента по его индексу
        public void FindElementByIndex()
        {
            Console.WriteLine("Finding an element by its indexes");
            Console.Write("enter row: ");
            var rowFind = GetIntNumber();
            Console.Write("enter column: ");
            var colFind = GetIntNumber();
            Console.WriteLine((rowFind < this.Rows && colFind < this.Columns)
                                ? (Math.Round(this.Data[rowFind, colFind], 2))
                                : "No such element in matrix");
        }
        // поиск среднего арифметического в каждом столбце
        public void FindAverageColumns()
        {
            var averagesColumns = new double[this.Columns];
            for (int i = 0; i < this.Columns; i++)
            {
                for (int j = 0; j < this.Rows; j++)
                {
                    averagesColumns[i] += this.Data[j, i];
                }
                averagesColumns[i] /= (double)this.Rows;
            }
            PrintAverages(averagesColumns);
        }
        // вывод средних арифметических всех столбцов
        private void PrintAverages(double[] numbers) =>
                    Console.WriteLine(string.Join(" | ", 
                        numbers.Select(n => Math.Round(n, 2))));

        // вывод матрицы в консоль
        public static void PrintMatrix(Matrix a)
        {
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    if (a.Type != 1) Console.Write("{0,9:n2}", a.Data[i, j]);
                    else Console.Write("{0,5:n0}", a.Data[i, j]);
                }
                Console.WriteLine();
            }
        }
        static Random rd => new Random();
        private int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
    }
}
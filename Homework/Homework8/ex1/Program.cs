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
            a.PrintMatrix();
            var b = new Matrix();
            b.PrintMatrix();
            try {
                var c = Matrix.MultiplyMatrix(a,b);
                Console.WriteLine("Multiply of matrixes: ");
                c.PrintMatrix();
            }
            catch
            {
                Console.WriteLine("imposible to multiply these matrixes");
            }
            Console.WriteLine("=======================");
            a.PrintMatrix();
            a.MinSumOfRows();
            a.SortingDataRows();

            

        }
    }
    class Matrix
    {
        public int Row { get; init; }
        public int Column { get; init; }
        public double[,]? Data { get; private set; }
        public Matrix()
        {
            Console.Write("enter rows: ");
            this.Row = GetIntNumber();
            Console.Write("enter columns: ");
            this.Column = GetIntNumber();
            this.Data = new double[this.Row, this.Column];
            Console.Write("enter min value of matrix: ");
            var minValue = GetIntNumber();
            Console.Write("enter max value of matrix: ");
            var maxValue = GetIntNumber();
            FillingDoubleMatrix(minValue, maxValue);
        }
        public Matrix(int row, int column)
        {
            this.Row = row;
            this.Column = column;
            this.Data = new double[this.Row, this.Column];

        }
        // сортировочка строк матрицы
        public void SortingDataRows()
        {
            Console.WriteLine("Sorted matrix is: ");
            this.Data = smt.SelectionSortRows(this.Data!);
            PrintMatrix();
        }
        // нахождение суммы строк и строки с минимальной суммой
        public void MinSumOfRows()
        {
            var sumOfRows = new double[this.Row];
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    sumOfRows[i] += this.Data![i,j];
                }
            }
            Console.WriteLine("sums of rows: " + string.Join(" | ",sumOfRows.Select(n=>Math.Round(n,2))));
            Console.WriteLine("min sum is in {0} row", 
                    Array.IndexOf(sumOfRows, sumOfRows.Min())+1);
        }
        // умножение матриц
        public static Matrix MultiplyMatrix(Matrix A, Matrix B)
        { 
            if (A.Column!=B.Row) 
                throw new Exception("can't multiply");
            var Res = new Matrix(A.Row, B.Column);
            // перебор элементов Res
            double elem;
            for (int i = 0; i < Res.Row; i++) // строки
            {   
                for (int j = 0; j < Res.Column; j++) // столбцы
                {
                    elem = 0;
                    for (int k = 0; k < B.Row; k++) // собрать элемент
                    { 
                        elem += A.Data![i,k] * B.Data![k,j];
                    }
                    Res.Data![i,j] = elem;
                }
            }
            return Res;
        }
        // вывод матрицы в консоль
        public void PrintMatrix()
        {
            Console.WriteLine();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    Console.Write("{0,9:n2}", this.Data![i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // заполнение матрицы
        private void FillingDoubleMatrix(int min, int max)
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    this.Data![i, j] = rd.NextDouble() * (max - min) + min;
                }
            }
        }
        private static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd = new Random();
        static Sorting smt = new Sorting();
    }
    // Сортировка строки. Пока что только выбором
    /* 
    * если дальше читать код голосом Дроздова,
    * то можно понять, что у меня знак зодиака овен
    * а тут ОВНОКод в естественной среде обитания
    */
    class Sorting
    {
        public double[,] SelectionSortRows(double[,] matrix)
        {
            var sortingArray = matrix;
            var row = sortingArray.GetLength(0);
            var column = sortingArray.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                var start = 0;
                while (start < column)
                {
                    var maxIndex = start;
                    for (int j = start; j < column; j++)
                    {
                        if (sortingArray[i,j]>sortingArray[i,maxIndex])
                        {
                            var temp = sortingArray[i,maxIndex];
                            sortingArray[i,maxIndex] = sortingArray[i,j];
                            sortingArray[i,j] = temp;
                        }
                    }
                    start++;
                }
                
            }
            return sortingArray;
        }
    }
}
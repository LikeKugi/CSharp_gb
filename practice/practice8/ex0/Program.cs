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
            Matrix.PrintArray(a);
            a.SwappingRows();
            Matrix.PrintArray(a);

        }
    }
    class Matrix
    {
        public int Row {get;init;}
        public int Column {get;init;}
        public int[,] Data {get; private set;}
        public Matrix()
        {
            this.Row = GetIntNumber();
            this.Column = GetIntNumber();
            this.Data = new int[this.Row,this.Column];
            FillingArray();

            
        }
        public void SwappingRows()
        {
            var swapFrom = GetIntNumber();
            var swapTo = GetIntNumber();
            var temp =0;
            for (int j = 0; j< this.Column;j++)
            {
                temp = this.Data[swapFrom,j];
                this.Data[swapFrom,j] = this.Data[swapTo,j];
                this.Data[swapTo,j] = temp;
            }
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
        public static void PrintArray(Matrix a)
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
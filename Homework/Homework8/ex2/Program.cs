using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var a = new Cube();
            a.PrintCube();

        }
    }
    class Cube
    {
        public int Row { get; init; }
        public int Column { get; init; }
        public int Tube { get; init; }
        public int[,,] Data { get; init; }
        public Cube()
        {
            do
            {
                Console.Write("how many rows? ");
                this.Row = GetIntNumber();
                Console.Write("how many columns? ");
                this.Column = GetIntNumber();
                Console.Write("how many tubes? ");
                this.Tube = GetIntNumber();
                this.Data = new int[this.Row, this.Column, this.Tube];
            } while (this.Row * this.Column * this.Tube >= 100);
            FillingIntRandom();
        }
        // заполнение массива
        // numbers - список уже существующих элементов в массиве
        private void FillingIntRandom()
        {
            var numbers = new List<int>();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    for (int k = 0; k < this.Tube; k++)
                    {
                        int element;
                        do
                        {
                            element = rd.Next(10, 100);
                        } while (numbers.IndexOf(element) > -1);
                        numbers.Add(element);
                        this.Data[i, j, k] = element;
                    }
                }
            }
        }
        public void PrintCube()
        {
            for (int tubes = 0; tubes < this.Tube; tubes++)
            {
                for (int rows = 0; rows < this.Row; rows++)
                {
                    for (int cols = 0; cols < this.Column; cols++)
                    {
                        Console.Write("{0,5} ({1};{2};{3})", this.Data[rows, cols, tubes], rows, cols, tubes);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static Random rd => new Random();
        static int GetIntNumber() => Convert.ToInt32(Console.ReadLine());
    }
}
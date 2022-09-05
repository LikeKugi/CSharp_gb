using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine("input 1 line: ");
            var lineOne = new Line();
            Console.WriteLine("input 2 line: ");
            var lineTwo = new Line();

            Line.GetCross(lineOne,lineTwo);

        }
    }
    class Line
    {
        private int _k;
        private int _b;
        public int Kcoef
        {
            get {return _k;}
            init {_k = value;}
        }
        public int Bcoef
        {
            get {return _b;}
            init {_b = value;}
        }
        public Line()
        {
            Console.WriteLine("===============");
            Console.WriteLine("y = k*x + b");
            Console.Write("k = ");
            Kcoef = GetCoef();
            Console.Write("b = ");
            Bcoef = GetCoef();
            Console.WriteLine("Line equation is: ");
            PrintEquation();
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        public void PrintEquation() => Console.WriteLine("y = {0}*x + {1}",this.Kcoef,this.Bcoef);
        public static void GetCross(Line a, Line b)
        {
            if (a.Kcoef != b.Kcoef)
            {
                Console.WriteLine("===============");
                Console.WriteLine("Finding intersection: ");
                double x = (double)(b.Bcoef - a.Bcoef)/(double)(a.Kcoef - b.Kcoef);
                double y = (a.Kcoef * x + a.Bcoef);
                a.PrintEquation();
                Console.WriteLine("intersects");
                b.PrintEquation();
                Console.WriteLine("in point: ({0:n3};{1:n3})",x,y);
            }
            else 
                if (a.Kcoef == b.Kcoef && a.Bcoef == b.Bcoef)
                {
                    a.PrintEquation();
                    Console.WriteLine("equals");
                    b.PrintEquation();
                } else 
                    {
                        a.PrintEquation();
                        Console.WriteLine("is parallel to ");
                        b.PrintEquation();
                    }
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        private int GetCoef() => Convert.ToInt32(Console.ReadLine());
    }
}
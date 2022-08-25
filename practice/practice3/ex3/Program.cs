using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine("enter coordinates of 1 point");
            var A = AskCoords();

            Console.WriteLine("enter coordinates of 2 point");
            var B = AskCoords();

            Console.WriteLine("distance between 2 points is {0:N2}", GetLength(A,B));

        }

        static double GetCoords() => Convert.ToDouble(Console.ReadLine());

        static double[] AskCoords()
        {
            var points = new double[2];
            for (int i = 0; i<points.Length;i++)
                points[i] = GetCoords();
            return points;
        }

        static double GetLength(double[]a, double[]b) => Math.Sqrt(Math.Pow(a[0]-b[0],2)+Math.Pow(a[1]-b[1],2));
    }
}
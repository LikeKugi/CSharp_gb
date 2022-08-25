using System;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine("enter coordinates of 1 point");
            var A = GetCoords();

            Console.WriteLine("enter coordinates of 2 point");
            var B = GetCoords();

            Console.WriteLine("distance between points is {0:N2}", FindLength(A,B));
        }

        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        static int[] GetCoords() => Enumerable.Range(1,3).Select(x=>GetNumber()).ToArray();

        static double FindLength(int[] a, int[] b) => Math.Sqrt(Math.Pow(a[0]-b[0],2)+Math.Pow(a[1]-b[1],2)+Math.Pow(a[2]-b[2],2));
        
    }
}
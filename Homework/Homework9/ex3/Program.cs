using System;
using System.Linq;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Console.Write("enter m: ");
            var m = GetIntNumber();
            Console.Write("enter n: ");
            var n = GetIntNumber();

            var ack = new Ackerman(m,n);
            
            ack.PrintRecursiveAckerman();
            

        }
        static ulong GetIntNumber() => Convert.ToUInt64(Console.ReadLine());
    }
    class Ackerman
    {
        private static ulong _counterRecursion = 0;
        public ulong MOfAckerman {get; private set;}
        public ulong NOfAckerman {get; private set;} 
        public static ulong RecursionCounter 
        {
            get{return _counterRecursion;} 
        }
        public Ackerman(ulong m, ulong n)
        {
            this.MOfAckerman = m;
            this.NOfAckerman = n;
            _counterRecursion = 0;
        }
        private ulong FindRecursiveAckerman(ulong m, ulong n)
        {
            _counterRecursion++;
            if (m==0)
            {
                return n+1;
            }
            if (m>0&&n==0)
            {
                return (FindRecursiveAckerman(m-1,1));
            }
            if (m>0&&n>0)
            {
                return (FindRecursiveAckerman(m-1,FindRecursiveAckerman(m,n-1)));
            }
            return 0;
        }
        public void PrintRecursiveAckerman()
        {
            var answer = FindRecursiveAckerman(this.MOfAckerman,this.NOfAckerman);
            Console.WriteLine("answer: {0}", answer); 
            Console.WriteLine("recursion calls = {0:n0}", RecursionCounter);
        }
    }
}
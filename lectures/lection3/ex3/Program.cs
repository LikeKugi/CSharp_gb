using System;
using System.Text;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var line = new StringBuilder(Console.ReadLine());
            var deleting = ' ';
            var newSymb = '_';

            var newLine = Replacing(line, deleting, newSymb).ToString();
            Console.WriteLine(newLine);
        }

        static StringBuilder Replacing (StringBuilder line, char delC, char newC)
        {
            for (int i = 0; i< line.Length; i++)
            {
                
                if (line[i] == delC)
                {
                    line[i] = newC;
                }
                
            }
            return line;
        }

        
    }
}
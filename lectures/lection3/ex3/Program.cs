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
                
                switch (line[i])
                {
                    case ' ':
                        line[i] = newC;
                    break;
                    case 'к':
                        line[i] = 'К';
                    break;
                    case 'с':
                        line[i] = 'С';
                    break;
                }
            }
            return line;
        }

        
    }
}
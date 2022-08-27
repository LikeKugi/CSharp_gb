using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            Method1();
            Method2(line: "hey"); // можно использовать именнованные аргументы
            Console.WriteLine(Method3());
            var str = Method4(10, "'c'");
            Console.WriteLine(str);
        }

        // no input no output
        static void Method1()
        {
            Console.WriteLine("____________");
        }

        // input no output
        static void Method2(string line)
        {
            Console.WriteLine(line.ToUpper());
        }

        // no input output
        static int Method3() => DateTime.Now.Year;

        // input output
        static string Method4(int count, string c)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result = string.Concat(result,c,'o');
            
            }
            return result;
        }
        
    }
}
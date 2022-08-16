using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine("enter username");
            string? username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
                username = "Joe";

            if (username.ToLower() == "masha")
            {
                Console.WriteLine($"hello {username}");
            }
            else
            {
                Console.WriteLine($"Not Masha but hello, {username}");
            }
        }
    }
}
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
            var value = GetNumber();
            var numbers = GetArrayFromNumber(value);

            if (CompareArrays(numbers))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

            var digits = GetDigits(value);

            if (CompareDigits(digits))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }

        static int GetNumber() => Convert.ToInt32(Console.ReadLine());

        // КОСТЫЛЯНДИЯ

        static int[] GetArrayFromNumber(int num)
        {
            var numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = num % 10;
                num /= 10;
            }
            return numbers;
        }

        static bool CompareArrays(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length / 2; i++)
            {
                if (numbers[i] != numbers[numbers.Length - 1 - i])
                    return false;
            }
            return true;
        }

        // just if more than 5 digits
        static List<int> GetDigits(int num)
        {
            num = Math.Abs(num);
            var digits = new List<int>();
            while (num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }
            return digits;
        }

        static bool CompareDigits(List<int>digits)
        {
            for (int i = 0; i <= digits.Count / 2; i++)
            {
                if (digits[i] != digits[digits.Count - 1 - i])
                    return false;
            }
            return true;
        }

    }
}
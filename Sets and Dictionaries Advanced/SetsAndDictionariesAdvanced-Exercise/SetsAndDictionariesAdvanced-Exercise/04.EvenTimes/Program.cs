using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            FillDictionary(numbers, line);
            PrintResult(numbers);

        }

        private static void PrintResult(Dictionary<int, int> numbers)
        {
            int num = 0;
            foreach (var number in numbers)
            {
                if (number.Value % 2 == 0)
                {
                    num = number.Key;
                }
            }

            Console.WriteLine(num);
        }

        static Dictionary<int, int> FillDictionary(Dictionary<int, int> numbers, int line)
        {
            for (int i = 0; i < line; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;

            }

            return numbers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());

                Stack<int> stack = new Stack<int>();
           

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                int command = input[0];

                while (true)
                {
                    if (command == 1)
                    {
                        
                            stack.Push(input[1]);

                        

                    }
                    else if (command == 2)
                    {
                        if (stack.Count>0)
                        {
                            stack.Pop();

                        }

                    }
                    else if (command == 3)
                    {
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                    }
                    else if (command == 4)
                    {
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }

                    }

                    break;
                }
            }
           
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}

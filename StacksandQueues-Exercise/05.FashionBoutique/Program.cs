using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(input);
            int sum = 0;
            int rackCount =1;
            while (clothes.Count>0)
            {
                sum += clothes.Peek();
                if (sum <= capacity)
                {
                     clothes.Pop();

                }

                else
                {
                    rackCount++;
                    sum = 0;
                }

            }

            
            Console.WriteLine(rackCount);
        }
    }
}

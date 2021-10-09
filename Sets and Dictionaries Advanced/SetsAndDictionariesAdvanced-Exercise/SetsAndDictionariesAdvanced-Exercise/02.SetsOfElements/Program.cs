using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = lenght[0];
            int m = lenght[1];

            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();

            HashSet<int> matched = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                
                setN.Add(int.Parse(Console.ReadLine()));
            }

            for (int r = 0; r < m; r++)
            {
                setM.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var element in setN)
            {

                if (setM.Contains(element))
                {
                    matched.Add(element);
                }

            }

          
            foreach (var element in matched)
            {

                Console.Write($"{element} ");
           
            }
            
        }
    }
}

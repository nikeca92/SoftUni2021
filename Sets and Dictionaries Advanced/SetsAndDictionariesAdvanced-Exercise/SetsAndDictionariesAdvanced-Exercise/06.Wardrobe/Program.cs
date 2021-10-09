using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            FillWardrobe(wardrobe, lines);
            string[] clothesToFind = Console.ReadLine().Split();
            string colour = clothesToFind[0];
            string cloth = clothesToFind[1];
            PrintResult(wardrobe, colour, cloth);

        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> wardrobe, string colour, string cloth)
        {
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var clothing in kvp.Value)
                {
                    if (colour == kvp.Key && cloth == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");

                    }

                }
            }
        }

        static Dictionary<string, Dictionary<string, int>> FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string currColour = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(currColour))
                {
                    wardrobe.Add(currColour, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[currColour].ContainsKey(clothes[j]))
                    {
                        wardrobe[currColour].Add(clothes[j], 0);
                    }

                    wardrobe[currColour][clothes[j]]++;
                }
            }

            return wardrobe;
        }
    }
}

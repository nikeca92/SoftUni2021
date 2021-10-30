using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _15.Food_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ").Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ").Select(char.Parse));
            int wordCount = 0;
            HashSet<string> result = new HashSet<string>();
            string[] words = new[] { "pear", "flour", "pork", "olive" };


            char currVowel = ' ';
            char currCons = ' ';
            for (int con = 0; con < consonants.Count; con++)
            {
                foreach (var word in words)
                {
                    currVowel = vowels.Dequeue();

                    if (word.Contains(currVowel) || word.Contains(currCons))
                    {
                        wordCount++;
                        result.Add(word);
                        vowels.Enqueue(currVowel);
                        
                    }
                    vowels.Enqueue(currVowel);
                    currCons = consonants.Pop();
                }
               
                
            }


            Console.WriteLine($"Words found: {wordCount}");
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

        }

    }
}

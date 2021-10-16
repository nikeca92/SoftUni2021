using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            int decrease = 0;
            while (effects.Count> 0 && casings.Count >0)
            {
                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    break;
                }
                int currentEffect = effects.Peek();
                int currentCassing = casings.Peek() - decrease;
                int combined = currentEffect + currentCassing;
                bool bombCombined = false;
                if (combined == 40)
                {
                    datura++;
                    bombCombined = true;
                }
                else if (combined == 60)
                {
                    cherry++;
                    bombCombined = true;
                }
                else if (combined == 120)
                {
                    smoke++;
                    bombCombined = true;
                }

                if (bombCombined)
                {
                    effects.Dequeue();
                    casings.Pop();
                    decrease = 0;
                }
                else if (currentCassing <=0)
                {
                    casings.Pop();
                    decrease = 0;
                }
                else
                {
                    decrease += 5;
                }
            }
            if (datura >= 3 && cherry >= 3 && smoke >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count==0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",effects)}");
            }

            if (casings.Count==0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}

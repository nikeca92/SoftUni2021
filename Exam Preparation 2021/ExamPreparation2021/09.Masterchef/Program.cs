using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _09.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Dictionary<string, int> dishes = new Dictionary<string, int>();
            dishes.Add("Chocolate cake", 0);
            dishes.Add("Dipping sauce", 0);
            dishes.Add("Green salad", 0);
            dishes.Add("Lobster", 0);
            int dipping = 0;
            int green = 0;
            int choco = 0;
            int lobster = 0;
            int sumDishesh = 0;
            while (true)
            {
                if (ingredients.Count <= 0 || freshness.Count <= 0)
                {
                    break;
                }
                int currIngredient = ingredients.Peek();
                int currFreshness = freshness.Peek();
                int sum = currIngredient * currFreshness;
                if (currIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                if (sum == 150)
                {
                    dipping++;
                    sumDishesh++;
                    dishes["Dipping sauce"] += 1;
                    ingredients.Dequeue();
                    freshness.Pop();
                }

                else if (sum == 250)
                {
                    green++;
                    sumDishesh++;
                    dishes["Green salad"] += 1;
                    ingredients.Dequeue();
                    freshness.Pop();
                }


                else if (sum == 300)
                {
                    choco++;
                    sumDishesh++;
                    dishes["Chocolate cake"] += 1;
                    ingredients.Dequeue();
                    freshness.Pop();
                }


                else if (sum == 400)
                {
                    lobster++;
                    sumDishesh++;
                    dishes["Lobster"] += 1;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {

                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                    freshness.Pop();
                }
            }

            if (sumDishesh >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            int sumIngrediant = 0;
            if (ingredients.Count > 0)
            {
                foreach (var ingredient in ingredients)
                {
                    sumIngrediant += ingredient;

                }

                Console.WriteLine($"Ingredients left: {sumIngrediant}");
            }

            foreach (var dish in dishes.OrderBy(x => x.Key))
            {
                if (dish.Value == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"# {dish.Key} --> {dish.Value}");

                }
            }
        }
    }
}

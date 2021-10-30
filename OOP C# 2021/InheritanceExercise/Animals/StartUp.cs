using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string typeOfAnimal = Console.ReadLine();
                if (typeOfAnimal == "Beast!")
                {
                    break;
                }
                string[] input = Console.ReadLine().Split();

                if (input[0].Length < 0 || int.Parse(input[1]) < 0)
                {
                    Console.WriteLine("Invalid input!");
                   continue;
                    
                }

                if (typeOfAnimal == "Cat" && input[2] == "Male")
                {
                    Cat cat = new Cat(input[0], int.Parse(input[1]), input[2]);
                   
                    animals.Add(cat);
                    continue;
                }

                if (typeOfAnimal == "Dog" )
                {
                    Dog dog = new Dog(input[0], int.Parse(input[1]), input[2]);
                    
                    animals.Add(dog);
                    continue;
                }

                if (typeOfAnimal == "Frog")
                {
                    Frog frog = new Frog(input[0], int.Parse(input[1]), input[2]);
                   
                    animals.Add(frog);
                    continue;
                }
                if(input[2] == "Kitten")
                {
                    Kitten animal = new Kitten(input[0], int.Parse(input[1]));
                    
                    animals.Add(animal);
                    continue;
                }

                if (input[2] == "Tomcat")
                {
                    Tomcat animal = new Tomcat(input[0], int.Parse(input[1]));
                   
                    
                    animals.Add(animal);
                }
               

               

            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }

        }

    }
}

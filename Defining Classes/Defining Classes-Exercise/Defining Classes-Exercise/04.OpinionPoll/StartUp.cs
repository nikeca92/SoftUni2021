using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                Person person = new Person(name, age);
                family.AddMember(person);

            }

            HashSet<Person> personAbove30 = family.GetAllPeopleAbove30();
            Console.WriteLine(string.Join(Environment.NewLine,personAbove30));
        }
    }
}

using System;

namespace Animals
{
   public class Dog : Animal
    {
        public override string ProduceSound()
        {
            return "Woof!";
        }

        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }
    }
}

using System;
using System.Threading.Channels;

namespace Animals
{
   public class Kitten : Cat
    {
        public Kitten(string name, int age) 
            : base(name, age, "Female")
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}

using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person("Peter", 20);
            
            Person george = new Person()
            {
                Name= "George",
                Age= 24
            };
            Person jose = new Person("Jose", 43);
           
        }
    }
}

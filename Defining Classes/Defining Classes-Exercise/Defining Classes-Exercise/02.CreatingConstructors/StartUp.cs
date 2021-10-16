using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var noName = new Person();
            var gosho = new Person(24);
            var ivan = new Person("Ivan", 27);
        }
    }
}

﻿using System;

namespace Animals
{
   public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public virtual string ProduceSound()
        {
            return "";
        }
    }
}

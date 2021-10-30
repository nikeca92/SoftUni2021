﻿using System;
using System.Diagnostics;
using System.Text;

namespace Person
{
   public class Person
   {
       private string name;
       private int age;
        public string Name {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age {
            get
            {
                return this.age;
            }

            set
            {
                if (value<0)
                {
                    throw new Exception();
                }

                this.age = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Format("Name: {0}, Age: {1}",
                this.Name,
                this.Age));

            return stringBuilder.ToString();
        }

    }
}

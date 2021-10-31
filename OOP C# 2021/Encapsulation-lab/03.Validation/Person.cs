using System;

namespace PersonsInfo
{
    public class Person
    {
        private decimal salary;
        private int age;
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");

                }

                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age Cannot be zero or a negative integer!");
                }

                age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }

                salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                this.Salary += this.Salary * (percentage / 2) / 100;

            }
            else
            {
                this.Salary += this.Salary * percentage / 100;

            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {(this.Salary):F2} leva.";
        }
    }
}


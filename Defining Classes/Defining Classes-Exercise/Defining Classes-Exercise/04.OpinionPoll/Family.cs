using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person person = this.members.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;
        }

        public HashSet<Person> GetAllPeopleAbove30()
            => this.members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToHashSet();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        public int Capacity { get; set; }
        public int Count
        {
            get { return data.Count; }
        }
        public Clinic(int capacity)
        {
            data = new List<Pet>();
            Capacity = capacity;
        }

        public void Add(Pet pet)
        {
            if (Capacity > data.Count)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            if (data.Count > 0)
            {
              Pet pet = data.FirstOrDefault(x => x.Name == name);
              if (pet == null)
              {
                  return false;
              }
              data.Remove(pet);
              
            }
            return true;

        }

        public Pet GetPet(string name, string owner)
        {
            if (data.Exists(x => x.Name == name && x.Owner == owner))
            {
                Pet pet = data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
                return pet ;
            }

            return null;
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("The clinic has the following patients:");

            foreach (var pet in data)
            {
                result.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return result.ToString();
        }
    }
}

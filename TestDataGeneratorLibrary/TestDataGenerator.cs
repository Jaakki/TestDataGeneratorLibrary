using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        public string GetRandomStringFromArray(string[] random)
        {
            Random roll = new Random();
            return random[roll.Next(1, random.Length)];
        }

        public Person GenerateRandomPerson()
        {
            Person person = new Person();
            person.FirstName = GetRandomStringFromArray(Person.firstNameMales);
            person.LastName = GetRandomStringFromArray(Person.lastNames);
            person.Age = RandomInt(0, 100);
            return person;
        }

        public int RandomInt(int min, int max)
        {
            Random roll = new Random();
            return roll.Next(min, max);
        }
    }
}

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
            person.LastName = 
            return person;
        }
    }
}

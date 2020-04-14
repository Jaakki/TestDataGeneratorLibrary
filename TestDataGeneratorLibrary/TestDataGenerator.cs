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
            person.sex = RandomSex();
            if (person.sex == Person.Sex.Male)
            {
                person.FirstName = GetRandomStringFromArray(Person.firstNameMales);
            }
            else
            {
                person.FirstName = GetRandomStringFromArray(Person.firstNameFemales);
            }
            
            person.LastName = GetRandomStringFromArray(Person.lastNames);
            person.Age = RandomInt(0, 100);
            return person;
        }

        public int RandomInt(int min, int max)
        {
            Random roll = new Random();
            return roll.Next(min, max);
        }

        public Person.Sex RandomSex()
        {
            Random randomSex = new Random();
            int mIndex = randomSex.Next(0,2);
            return (Person.Sex)mIndex;
        }

        public List<Person> GetListOfRandomPersons(List<Person> people, int pers)
        {
            for (int i = 0; i < pers; i++)
            {
                people.Add(GenerateRandomPerson());
            }
            return people;
        }

        public void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} - {person.sex} - {person.Age}");
        }

        public void PrintPeople(List<Person> people)
        {
            foreach (var person in people)
            {
                PrintPerson(person);
            }
            Console.WriteLine($"There were {people.Count} people in list.");
        }
    }
}

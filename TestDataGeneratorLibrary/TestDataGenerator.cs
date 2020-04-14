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

            //if (randomSex = 0)
            //{
            //    return Person.Sex.Male;
            //}

            //else
            //{
            //    return Person.Sex.Female;
            //}
        }
    }
}

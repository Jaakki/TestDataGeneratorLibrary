using System;
using TestDataGeneratorLibrary;

namespace Konsoli
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDataGenerator test = new TestDataGenerator();
            test.GetRandomStringFromArray(Person.firstNameMales);
            test.GenerateRandomPerson();
            
            


        }
    }
}

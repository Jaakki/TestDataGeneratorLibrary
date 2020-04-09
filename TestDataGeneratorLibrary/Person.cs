using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class Person
    {
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public static string[] firstNameMales = { "Julle", "Pentti", "Jaakko", "Henrik", "Onni", "Otto", "Sauli", "Matti" };

		public List<Person> lastNames = new List<Person>();
		

	}
}

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

		public Sex sex { get; set; }

		public static string[] firstNameMales = { "Julle", "Pentti", "Jaakko", "Henrik", "Onni", "Otto", "Sauli", "Matti" };

		public static string[] firstNameFemales = { "Sara", "Jenna", "Helena", "Anna", "Kirsi", "Annika", "Iisa", "Juulia" };

		public static string[] lastNames = { "Rautio", "Pekkala", "Niiranen", "Jankkila", "Seppälä", "Mustonen", "Korpelainen", "Loponen" };

		public enum Sex
		{
			Male,
			Female
		}


	}
}

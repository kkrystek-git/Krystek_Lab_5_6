using System;
using System.Runtime.ExceptionServices;

namespace Krystek_Lab_5_6
{
	class Program
	{	struct Customer
		{
			public string firstName;
			public string lastName;
			public int age;
			public bool isLegalAge;
			public bool isPremiumMember;
			public DateTime lastUpdated;
		};

		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.30.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 5_6
			// =========================================================================
			//
			//
			// 1.Create 3 Customers with Different Profiles.
			// 2.Test Profiles to See to which Group They Belong.
			//



			// 1.Create 3 Customers with Different Profiles.

			Customer Customer1 = new Customer
			{
				firstName = "Norm",
				lastName = "Peterson",
				age = 62,
				isPremiumMember = true
			};

			Customer Customer2 = new Customer
			{
				firstName = "Cliff",
				lastName = "Clavin",
				age = 65,
				isPremiumMember = false
			};

			Customer Customer3 = new Customer
			{
				firstName = "Sammy",
				lastName = "Malone",
				age = 15,
				isPremiumMember = false
			};




			// 2.Test Profiles to See to which Group They Belong.

			Customer[] customerList = {Customer1, Customer2, Customer3};

			for (int i = 0; i < customerList.Length; i++)
			{
				if (customerList[i].age < 21)
					{customerList[i].isLegalAge = false;}
				else if (customerList[i].age >= 21)
					{customerList[i].isLegalAge = true;}
				else
					{customerList[i].isLegalAge = false;}

				customerList[i].lastUpdated = DateTime.Now;

				if (customerList[i].isLegalAge == false)
				{
					Console.WriteLine(customerList[i].firstName + " " + customerList[i].lastName + " is NOT old enough to buy beer.\n");
				}
				else
				{
					if (customerList[i].isPremiumMember == false)
					{
						Console.WriteLine(customerList[i].firstName + " " + customerList[i].lastName + " is old enough to buy beer, but is only a regular member.\n");
					}
					else
					{
						Console.WriteLine(customerList[i].firstName + " " + customerList[i].lastName + " is old enough to buy beer and is a Premium member.\n");
					}
				}
			};




			// 3.Display Detail of Profiles for Review (and for Fun).


			Console.WriteLine("Press 'Enter' to continue ...");
				Console.ReadLine();
				Console.Clear();

				for (int i = 0; i < customerList.Length; i++)
				{
					Console.WriteLine(("First Name: ").PadRight(17) + customerList[i].firstName);
					Console.WriteLine(("Last Name: ").PadRight(17) + customerList[i].lastName);
					Console.WriteLine(("Age: ").PadRight(17) + customerList[i].age);
					Console.WriteLine(("Legal Age: ").PadRight(17) + customerList[i].isLegalAge);
					Console.WriteLine(("Premium Member: ").PadRight(17) + customerList[i].isPremiumMember);
					Console.WriteLine(("Last Updated: ").PadRight(17) + customerList[i].lastUpdated);
					Console.WriteLine("\n\n");

					Console.WriteLine("Press 'Enter' to continue ...");
					Console.ReadLine();
					Console.Clear();
			};


			// End

		}
	}
}

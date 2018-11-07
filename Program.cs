using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPref
{
  class Program
  {
    public static void Main()
    {
			List<Person> users = new List<Person>();
			int userInput;
			do
			{
				userInput = DisplayMenu(users);
			} while(userInput!=0);
    }

		static public int DisplayMenu(List<Person> users)
		{   
			Console.WriteLine("Preferred Pizza Picker");
			Console.WriteLine();
			Console.WriteLine("1. Add a New User");
			Console.WriteLine("2. Review an Existing User");
			Console.WriteLine("0. Exit");
			var result = Int32.Parse(Console.ReadLine());
			switch (result)
			{
				case 1:
					users.Add(CreateUser());
					break;
				case 2:
					FindUser(users);
					break;
				case 0:
					Console.WriteLine("See you later! (press any key)");
					Console.ReadKey();
					break;
				default:
					DisplayMenu(users);
					break;
			}
			return result;
		}

		public static Person CreateUser()
		{
			Console.WriteLine("Please enter the following information:");
			Console.WriteLine("Full name: ");
			var name = Console.ReadLine();
			Console.WriteLine("Email: ");
			var email = Console.ReadLine();

			ToppingList toppingList = new ToppingList();
      List<ITopping> toppings = SurveyToppings(toppingList);

			Person person = new Person(name, email, toppings);
			return person;
		}

		public static void FindUser(List<Person> users)
		{
			Console.WriteLine("Please enter the email address of the user you would like to find.");
			var email = Console.ReadLine();
			var foundUser = users.Where(u => u.Email == email);
			Console.WriteLine();
			foreach (Person person in foundUser)
			{
				Console.WriteLine(person.FullName);
				foreach (Topping topping in person.ToppingPrefs)
				{
					Console.WriteLine(string.Format("{0}: {1}", topping.Name, topping.LikeScale));
				}
			}
		}

		public static List<ITopping> SurveyToppings(ToppingList toppingList)
		{
			Console.WriteLine("Please rate the following toppings from 1 to 5, 1 being least liked and 5 being most liked. For any toppings you cannot eat, use 0.");
			int likeness = 0;
			List<ITopping> toppings = new List<ITopping>(toppingList.Toppings.Length);
			for(int i = 0; i < toppingList.Toppings.Length; i++)
			{
				Console.WriteLine(toppingList.Toppings[i] + ": ");
				likeness = Int32.Parse(Console.ReadLine());
				Topping toAdd = new Topping(
					toppingList.Toppings[i],
					likeness,
					true,
					true
				);
				toppings.Add(toAdd);
			}
			return toppings;
		} 
  }
}

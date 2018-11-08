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
			UserList userlist = new UserList();
			Menu menu = new Menu(userlist);
			menu.Display();
    }

		// static public int DisplayMenu()
		// {   
		// 	Console.WriteLine("Preferred Pizza Picker");
		// 	Console.WriteLine();
		// 	Console.WriteLine("1. Add a New User");
		// 	Console.WriteLine("2. Review an Existing User");
		// 	Console.WriteLine("0. Exit");
		// 	var result = Int32.Parse(Console.ReadLine());
		// 	switch (result)
		// 	{
		// 		case 1:
		// 			U
		// 			break;
		// 		case 2:
		// 			FindUser(users);
		// 			break;
		// 		case 0:
		// 			Console.WriteLine("See you later! (press any key)");
		// 			Console.ReadKey();
		// 			break;
		// 		default:
		// 			DisplayMenu(users);
		// 			break;
		// 	}
		// 	return result;
		// }
  }
}

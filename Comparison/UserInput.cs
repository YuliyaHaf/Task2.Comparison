using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
	public static class UserInput
	{
		public static void MainMenu()
		{
			int choice = -1;
			Console.WriteLine("This application allows to compare different lists' work.\n");

			while (choice != 0)
			{
				Console.WriteLine("Select one of the options below: ");
				Console.WriteLine("1. Compare Array List vs Linked List.");
				Console.WriteLine("2. Compare Stack vs Linked Queue.");
				Console.WriteLine("3. CompareHash Table vs Dictionary.");
				Console.WriteLine("4. Exit. \n");

				try
				{
					choice = Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("No such option! Please, try again or press 0 to exit!\n");
					Console.ReadLine();
					choice = -1;
				}

				switch (choice)
				{
					case 1:
						ArrayListCollection.ArrayListCreation();
						LinkedListCollection.LinkedListCreation();
						break;

					case 2:
						//Methods2();
						break;

					case 3:
						//Methods3();
						break;

					case 4:
						//Methods4();
						break;
				}

			}
			Console.ReadLine();
		}
	}
}

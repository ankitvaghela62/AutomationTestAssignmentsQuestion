using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Program 1

			int number;
			Console.Write("Enter a number: ");
			if (int.TryParse(Console.ReadLine(), out number))
			{
				if (number % 2 == 0)
				{
					Console.WriteLine("The number is even.");
				}
				else
				{
					Console.WriteLine("The number is odd.");
				}
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid number.");
			}

			//Program 2

			int age;
			Console.Write("Enter your age: ");
			if (int.TryParse(Console.ReadLine(), out age))
			{
				string message;

				switch (age)
				{
					case 18:
						message = "You are not allowed to work";
						break;
					case 36:
						message = "You are allowed to work";
						break;
					case 60:
						message = "You are too old to work";
						break;
					default:
						message = "Provide the actual age";
						break;
				}

				Console.WriteLine(message);
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid age.");
			}


			// Program 3 using for loop

			int age1;
			Console.Write("Enter your age: ");
			if (int.TryParse(Console.ReadLine(), out age1))
			{
				if (age1 > 18)
				{
					for (int i = 0; i < 3; i++)
					{
						Console.WriteLine("You are eligible to vote in India.");
					}
				}
				else
				{
					for (int i = 0; i < 5; i++)
					{
						Console.WriteLine("Please complete your education.");
					}
				}
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid age.");
			}


			// Program 3 using do while loop

			Console.Write("Enter your age: ");
			if (int.TryParse(Console.ReadLine(), out age1))
			{
				if (age1 > 18)
				{
					int count = 0;
					do
					{
						Console.WriteLine("You are eligible to vote in India.");
						count++;
					} while (count < 3);
				}
				else
				{
					int count = 0;
					do
					{
						Console.WriteLine("Please complete your education.");
						count++;
					} while (count < 5);
				}
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid age.");
			}

			// Program 3 using while loop

			
			Console.Write("Enter your age: ");
			if (int.TryParse(Console.ReadLine(), out age1))
			{
				if (age1> 18)
				{
					int count = 0;
					while (count < 3)
					{
						Console.WriteLine("You are eligible to vote in India.");
						count++;
					}
				}
				else
				{
					int count = 0;
					while (count < 5)
					{
						Console.WriteLine("Please complete your education.");
						count++;
					}
				}
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid age.");
			}

			//Program 4.1 and 4.2

		   addition ad = new addition();
			ad.AddNum();
			ad.Area();
		
		
		}

	}
}

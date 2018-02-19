using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class ConsoleReader
	{ 

	  public static int ReadNumber()
		{
			string number;
			int intnumber;

			do
			{
				Console.WriteLine("Enter the number: ");
				number = Console.ReadLine();

			} while (!(int.TryParse(number, out intnumber)));

			return intnumber;
		}

		public static string AskToContinue()
		{
			string answer;
			Console.WriteLine("Continue?(y/any)");
			answer = Console.ReadLine();
			return answer;
		}

	}
}

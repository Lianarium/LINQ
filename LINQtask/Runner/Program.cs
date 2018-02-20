using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Xml.Linq;
using System.Collections;

namespace Runner
{
	class Program
	{
		static void Main(string[] args)
		{

			/*ArrayList secuence = FibonacciSecuence.CreateFibonacciSecuence();

			Console.WriteLine("Enter size of secuence: ");
			int secuencesize = ConsoleReader.ReadNumber();

			for (int i = 1; i <= secuencesize; i++)
			{
				secuence.Add(FibonacciSecuence.mtx2x2.fibm(i));

			}

			
            FibonacciSecuence.mtx2x2.OutputSecuence(secuence);
            Console.WriteLine("----------Secuence size: " + secuence.Count);
			Console.WriteLine("----------Prime numbers: ");
			SelectNumbers.SelectPrimeNumbers(secuence);
			Console.WriteLine("----------Condition 2: ");
			SelectNumbers.SelectNubersMultipleOfDigitsSum(secuence);
			Console.WriteLine("----------Condition 3: ");
			SelectNumbers.SelectNubersMultipleOf(5,secuence);
			Console.WriteLine("----------Condition 4: ");
			SelectNumbers.CountQuadraticRootsOfNumsWhichHaveDigitTwo(secuence);
			Console.WriteLine("----------Condition 5: ");
			SelectNumbers.SortBySecondDigit(secuence);
            Console.WriteLine("----------Condition 7: ");
            SelectNumbers.MaxSumOfDigitsPowerTwo(secuence);
            Console.WriteLine("----------Condition 8: ");
            SelectNumbers.AverageAmountOfZeros(secuence);
			//Console.WriteLine("Condition 6: ");
			//SelectNumbers.SelectAccordingToCondition6(secuence);
			*/


			Console.WriteLine("Enter the amount of money to compare: ");
             XMLWorker.ChooseCustomersWhoseTotalOrderSumIsBiggerThan(ConsoleReader.ReadNumber());

			  //Console.Clear();
			Console.WriteLine("Enter the amount of money to compare: ");

			XMLWorker.ChooseCustomersWhoHadOrdersBiggerThan(ConsoleReader.ReadNumber());
			XMLWorker.GroupByCountries();
            XMLWorker.SinceWhenIsAClient();
           // XMLWorker.GroupByCountries();
		}
	}
}

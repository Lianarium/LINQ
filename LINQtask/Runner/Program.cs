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
			FibonacciSecuence fibonaccisecuence = new FibonacciSecuence(20);


			for (int i = 1; i <= 20; i++)
			{
				fibonaccisecuence.Fibsec.Add(FibonacciSecuence.mtx2x2.fibm(i));

			}

			foreach (BigInteger element in fibonaccisecuence.Fibsec)
			{
				Console.WriteLine(element);
			}

			//FibonacciSecuence.mtx2x2.Out(fibonaccisecuence);
			Console.WriteLine("Secuence size: " + fibonaccisecuence.Fibsec.Count);
			Console.WriteLine("Prime numbers: ");
			SelectNumbers.SelectPrimeNumbers(fibonaccisecuence);
			Console.WriteLine("Condition 2: ");
			SelectNumbers.SelectNubersMultipleOfDigitsSum(fibonaccisecuence);
			Console.WriteLine("Condition 3: ");
			SelectNumbers.SelectNubersMultipleOfFive(fibonaccisecuence);
			Console.WriteLine("Condition 4: ");
			SelectNumbers.CountQuadraticRootsOfNumsWhichHaveDigitTwo(fibonaccisecuence);
			Console.WriteLine("Condition 5: ");
			SelectNumbers.SortBySecondDigit(fibonaccisecuence);


			Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");

			//XMLWorker.ChooseCustomersWhoseTotalOrderSumIsBiggerThan(5000);
			//Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
			//Console.Clear();
			//XMLWorker.ChooseCustomersWhoHadOrdersBiggerThan(4000);
			XMLWorker.SinceWhenIsAClient();
		}
	}
}

﻿using Classes;
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
            /*Console.WriteLine("Secuence size: " + fibonaccisecuence.Fibsec.Count);
			Console.WriteLine("Prime numbers: ");
			SelectNumbers.SelectPrimeNumbers(fibonaccisecuence.Fibsec);
			Console.WriteLine("Condition 2: ");
			SelectNumbers.SelectNubersMultipleOfDigitsSum(fibonaccisecuence.Fibsec);
			Console.WriteLine("Condition 3: ");
			SelectNumbers.SelectNubersMultipleOf(5,fibonaccisecuence.Fibsec);
			Console.WriteLine("Condition 4: ");
			SelectNumbers.CountQuadraticRootsOfNumsWhichHaveDigitTwo(fibonaccisecuence.Fibsec);
			Console.WriteLine("Condition 5: ");
			SelectNumbers.SortBySecondDigit(fibonaccisecuence.Fibsec);
            Console.WriteLine("Condition 6: ");
            SelectNumbers.MaxSumOfDigitsPowerTwo(fibonaccisecuence.Fibsec);
            Console.WriteLine("Condition 7: ");
            SelectNumbers.AverageAmountOfZeros(fibonaccisecuence.Fibsec);

            foreach (BigInteger element in fibonaccisecuence.Fibsec)
            {
              Counter.GetLastTwoDigits(element);
            }
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            */

            //XMLWorker.ChooseCustomersWhoseTotalOrderSumIsBiggerThan(5000);
            //Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //Console.Clear();
            //XMLWorker.ChooseCustomersWhoHadOrdersBiggerThan(4000);
            //XMLWorker.SinceWhenIsAClient();
            XMLWorker.GroupByCountries();
		}
	}
}

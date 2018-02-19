using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace Classes
{
   public  class SelectNumbers
    {
		public static void SelectPrimeNumbers(FibonacciSecuence obj)
		{

			var query = from BigInteger bigintnum in obj.Fibsec
						where (bigintnum.IsPrime() ==true)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);

		}

		public static void SelectNubersMultipleOfDigitsSum(FibonacciSecuence obj)
		{
			var query = from BigInteger bigintnum in obj.Fibsec
						where (bigintnum % Counter.CountSumOfDigits(bigintnum)==0)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);
		}

		public static void SelectNubersMultipleOfFive(FibonacciSecuence obj)
		{
			var query = from BigInteger bigintnum in obj.Fibsec
						where (bigintnum % 5 == 0)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);
		}

		public static void CountQuadraticRootsOfNumsWhichHaveDigitTwo(FibonacciSecuence obj)
		{
			var query = from BigInteger bigintnum in obj.Fibsec
						where (Counter.FindDigitTwo(bigintnum) == true)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);
		}

		public static void SortBySecondDigit(FibonacciSecuence obj)
		{
			var query = from BigInteger bigintnum in obj.Fibsec
						orderby Counter.FindSecondDigit(bigintnum) descending
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);

		}

		public static void MaxSumOfDigitsPowerTwo(FibonacciSecuence obj)
		{
			 
		 
		}

	} 
}

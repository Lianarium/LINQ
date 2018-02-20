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
		public static void SelectPrimeNumbers(ArrayList array)
		{

			var query = from BigInteger bigintnum in array 
						where (bigintnum.IsPrime() ==true)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);

		}

		public static void SelectNubersMultipleOfDigitsSum(ArrayList array)
		{
			var query = from BigInteger bigintnum in array 
						where (bigintnum % Counter.CountSumOfDigits(bigintnum)==0)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);
		}

		public static void SelectNubersMultipleOf(int multiplier, ArrayList obj)
		{
			var query = from BigInteger bigintnum in obj 
						where (bigintnum % multiplier == 0)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);
		}

		public static void CountQuadraticRootsOfNumsWhichHaveDigitTwo(ArrayList obj)
		{
			var query = from BigInteger bigintnum in obj 
						where (Counter.FindDigitTwo(bigintnum) == true)
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i + "  " + Counter.SquareFromBigInt(i));
		}

		public static void SortBySecondDigit(ArrayList obj)
		{
			var query = from BigInteger bigintnum in obj 
						orderby Counter.FindSecondDigit(bigintnum) descending
						select bigintnum;

			foreach (BigInteger i in query)
				Console.WriteLine(i);

		}

		public static void MaxSumOfDigitsPowerTwo(ArrayList obj)
		{
            var query = from BigInteger bigintnum in obj 
                        select Counter.SumOfDigitsPowerTwo(bigintnum);

            BigInteger max = query.Max();
            Console.WriteLine(max);

        }

        public static void SelectAccordingToCondition6(ArrayList array)
        {
            var query = from BigInteger bigintnum in array
                        where (Counter.FindDigitTwo(bigintnum) == true)
                        select bigintnum;

            foreach (BigInteger i in query)
                Console.WriteLine(i + "  " + Counter.SquareFromBigInt(i));
        }

        public static void AverageAmountOfZeros(ArrayList array)
        {
            var query = from BigInteger bigintnum in array 
                        select Counter.CountZerosInNumber(bigintnum);

            Console.WriteLine(query.Average());
             
        }

    } 
}

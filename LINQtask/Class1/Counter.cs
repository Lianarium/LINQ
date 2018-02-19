using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Counter
	{
		public static BigInteger CountSumOfDigits(BigInteger num)
		{
			BigInteger sum = 0;
			while (num != 0)
			{
				sum += num % 10;
				num /= 10;
			}

			return sum;
		}

		public static bool FindDigitTwo(BigInteger num)
		{
			BigInteger digit = 0;
			while (num != 0)
			{
				if (num % 10 == 2)
				{ digit++; }
				num /= 10;
			}
			if (digit != 0)
				return true;
			else return false;
		}

		public static int FindSecondDigit(BigInteger num)
		{
			string representstring = num.ToString();
			char[] representarray = representstring.ToCharArray();
			if (representarray.Length > 1)
			{
				string seconddigit;
				{seconddigit = Convert.ToString(representarray[1]); }
				return Convert.ToInt32(seconddigit);
			}
			else return 0;
		}

		public static BigInteger SumOfDigitsPowerTwo(BigInteger num)
		{
			BigInteger sum = 0;
			while (num != 0)
			{
				sum += (num % 10)*(num % 10);
				num /= 10;
			}

			return sum;
		}
	}
}

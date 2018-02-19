using System;
using System.Collections;
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


        public static int CountZerosInNumber(BigInteger num)
        {
            string representstring = num.ToString();
            char[] representarray = representstring.ToCharArray();
            int countzeros = 0;

            
                 for (int i=0; i<representarray.Length; i++)
                {
                    if (representarray[i] == '0')
                        countzeros++;
                }

            return countzeros;
            

        }

        public static BigInteger GetLastTwoDigits(BigInteger num)
        {
            int numberofdigits=0;

            while (num != 0)
            {
                numberofdigits++;
                num /= 10;
            }

            BigInteger lasttwodigits=0;
            if (numberofdigits >= 3)
            { lasttwodigits = num % 100; }
            else if (numberofdigits <=2 )
            {  lasttwodigits= num; }


            return lasttwodigits;
        }


        public static BigInteger SquareFromBigInt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!IsSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        public static bool IsSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }
	}
}

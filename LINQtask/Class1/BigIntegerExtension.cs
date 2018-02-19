using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
 

namespace Classes
{
    public static class BigIntegerExtension
	{
		 
	  public static bool IsPrime(this BigInteger n)
		{
			for (BigInteger i = 2; (i*i) < n; i++)
				if (n % i == 0)
					return false;
			return true;
			
		}

			
	}
    }


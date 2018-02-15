using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Runner
{
	class Program
	{
		static void Main(string[] args)
		{
			FibonacciSecuence fibonaccisecuence = new FibonacciSecuence(10);
			 
			 
			for (int i = 1; i <= 200; i++)
			{
				fibonaccisecuence.Fibsec.Add(FibonacciSecuence.mtx2x2.fibm(i));
			}
			FibonacciSecuence.mtx2x2.Out(fibonaccisecuence);
			Console.WriteLine(fibonaccisecuence.Fibsec.Count);
		}
	}
}

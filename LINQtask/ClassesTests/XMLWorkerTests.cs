using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Tests
{
	[TestClass()]
	public class XMLWorkerTests
	{
		[TestMethod()]
		public void ChooseCustomersWhoseTotalOrderSumIsBiggerThanTest()
		{
			//arrange
			int expected = 38;

			//act
			int actual = XMLWorker.ChooseCustomersWhoseTotalOrderSumIsBiggerThan(10000);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void ChooseCustomersWhoHadOrdersBiggerThanTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void SinceWhenIsAClientTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void GroupByCountriesTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void GroupByYearTest()
		{
			Assert.Fail();
		}
	}
}
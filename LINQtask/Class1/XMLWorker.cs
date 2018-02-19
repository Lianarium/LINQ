using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
	public class XMLWorker
	{

		 

		public static void ChooseCustomersWhoseTotalOrderSumIsBiggerThan(double sumtocompare)
		{
			XElement root = XElement.Load("Customers.xml");
			IEnumerable<XElement> customers =
				from customer in root.Elements("customer")
				select customer;
			foreach (XElement customer in customers)
			{
				double sum = 0;
				root = customer.Element("orders");
				IEnumerable<XElement> orders =
				from order in root.Elements("order")
				select order;
				foreach (XElement order in orders)
				{

					root = order.Element("total");
					Console.WriteLine(root);
					sum += Convert.ToDouble(root.Value);
				}

				if (sum > sumtocompare)
					Console.WriteLine("Next Customer: " + sum);
			}	

		}

		
		public static void ChooseCustomersWhoHadOrdersBiggerThan(double sumtocompare)
		{
			XElement root = XElement.Load("Customers.xml");
			IEnumerable<XElement> customers =
				from customer in root.Elements("customer")
				select customer;
			foreach (XElement customer in customers)
			{

				XElement elname = customer.Element("name");

				root = customer.Element("orders");
				IEnumerable<XElement> orders =
				from order in root.Elements("order")
				select order;
			 
				foreach (XElement order in orders)
				{

					root = order.Element("total");
					if (Convert.ToDouble(root.Value) > sumtocompare)
						Console.WriteLine("Next Customer: " + elname.ToString());

				}

				

			}

		}

		public static void SinceWhenIsAClient()
		{
			XElement root = XElement.Load("Customers.xml");
			IEnumerable<XElement> customers =
				from customer in root.Elements("customer")
				select customer;
			foreach (XElement customer in customers)
			{

				XElement elname = customer.Element("name");

				root = customer.Element("orders").Element("order").Element("orderdate");
				if (root!=null)
				Console.WriteLine(elname.Value + " is customer since " + root.Value);


			}
		}
	}
}
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

		 

		public static int ChooseCustomersWhoseTotalOrderSumIsBiggerThan(double sumtocompare)
		{
			XElement root = XElement.Load("Customers.xml");
			IEnumerable<XElement> customers =
				from customer in root.Elements("customer")
				select customer;
			    int countcustomers = 0;
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
                    
					sum += Convert.ToDouble(root.Value);

				}
                
				if (sum > sumtocompare)
					Console.WriteLine("{0} - {1}", "Next Customer: " ,sum);
				countcustomers++;
			}

			return countcustomers;
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
						Console.WriteLine("{0} - {1} - {2}", "Next Customer: ",elname.Value.ToString(),root.Value.ToString());

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

                if ((customer.Element("orders")!=null) && (customer.Element("orders").Element("order")!=null))

				{
                    root = customer.Element("orders").Element("order").Element("orderdate");
                    Console.WriteLine("{0} - {1}", elname.Value + " is customer since " , root.Value);
                }
                else continue;
			}
		}


        public static void GroupByCountries()
        {

			XElement root = XElement.Load("Customers.xml");
		        var customers =
				from customer in root.Elements("customer")
				select new
				{
					country = (string)customer.Element("country"),
					name = (string)customer.Element("name"),
				};

			  var grouped = from cust in customers
						  group cust by cust.country into gr
						  select new
						  {
							  country = gr.Key,
					           
						  };

			 foreach (var el in grouped)
			{
				Console.WriteLine(el.ToString());
				 
			}
		}

		public static void GroupByYear()
		{

			XElement root = XElement.Load("Customers.xml");
			var customers =
			from customer in root.Elements("customer")
			select new
			{
				orderdate = (string)customer.Element("orderdate"),
				//name = (string)customer.Element("name"),
			};

			var grouped = from cust in customers
						  group cust by cust.orderdate into gr
						  select new
						  {
							  country = gr.Key,

						  };

			foreach (var el in grouped)
			{
				Console.WriteLine(el.ToString());

			}
		}
	}
}
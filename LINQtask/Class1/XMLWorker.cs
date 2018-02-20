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
                    //double value;
					root = order.Element("total");
					Console.WriteLine(root);
                    //if (double.TryParse(root.Value, out value))
					sum += Convert.ToDouble(root.Value);
				}
                Console.WriteLine(sum);
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

                if (customer.Element("orders")!=null) 
                {
                    root = customer.Element("orders").Element("order").Element("orderdate");
                    Console.WriteLine(elname.Value + " is customer since " + root.Value);
                }
                else continue;
			}
		}


        public static void GroupByCountries()
        {
            XElement root = XElement.Load("Customers.xml");
            IEnumerable<XElement> customers =
                from customer in root.Elements("customer")
                group customer by customer.Element("country").Value;
                //group customer by customer.Element("country");


            foreach (XElement customer in customers)
            {


                Console.WriteLine(customer);

            }
        }
	}
}
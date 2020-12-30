using CodeFromNorthwindModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFromNorthwindBusiness
{
	public class CRUDManager
	{
		public Customer SelectedCustomer { get; set; }


		public List<Customer> RetrieveAll()
		{
			using (var db = new NorthwindContext())
			{
				return db.Customers.ToList();
			}
		}

        static void Main(string[] args)
		{
			using (var db = new NorthwindContext())
			{



			}
		}
		public void CreateCustomer(string customerid, string contactname, string companyname)
		{

			using (var db = new NorthwindContext())
			{
				var newCustomer = new Customer
				{
					CustomerId = customerid.Trim(),
					ContactName = contactname.Trim(),
					CompanyName = companyname.Trim()
				};

				db.Customers.Add(newCustomer);

				db.SaveChanges();
			}


		}

		public void UpdateCustomerDetails(string customerId, string contactName, string city, string postcode, string country)
		{
			using (var db = new NorthwindContext())
			{
				SelectedCustomer = db.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
				SelectedCustomer.ContactName = contactName;
				SelectedCustomer.City = city;
				SelectedCustomer.PostalCode = postcode;
				SelectedCustomer.Country = country;

				// write changes to database
				db.SaveChanges();
			}
		}


		public void UpdateCustomerCity(string customerid, string city)
		{
			using (var db = new NorthwindContext())
			{
				// obtain your selected customer
				var selectedCustomer =
						from c in db.Customers
						where c.CustomerId == customerid
						select c;
				// now update
				foreach (var item in selectedCustomer)
				{
					item.City = city;
				}



				db.SaveChanges();
			}

		}

		public void DeleteCustomer(string customerid)
		{

			using (var db = new NorthwindContext())
			{
				var selectedCustomer =
			from c in db.Customers
			where c.CustomerId == customerid
			select c;

				db.Customers.RemoveRange(selectedCustomer);


				db.SaveChanges();
			}
		}
	}
}
using System.Linq;
using CodeFromNorthwindModel;
using CodeFromNorthwindBusiness;
using NUnit.Framework;


namespace NorthwindTests
{
	public class CustomerCRUDTests
	{
		CRUDManager _crudManager = new CRUDManager();

		[SetUp]

		public void Setup()
		{
			using (var db = new NorthwindContext())
			{

				var selectedCustomers =
				from c in db.Customers
				where c.CustomerId == "MAND"
				select c;

				db.Customers.RemoveRange(selectedCustomers);

				db.SaveChanges();
			}
		}

		[TearDown]

		public void TearDown()
		{
			using (var db = new NorthwindContext())
			{

				var selectedCustomers =
				from c in db.Customers
				where c.CustomerId == "MAND"
				select c;


				db.Customers.RemoveRange(selectedCustomers);

				db.SaveChanges();
			}
		}


		[Test]
		public void WhenANewCustomerIsAdded_TheNumberOfCustemersIncreasesBy1()
		{
			using (var db = new NorthwindContext())
			{
				var numberBefore = db.Customers.ToList().Count();
				_crudManager.CreateCustomer("MAND", "Nish Mandal", "Sparta Global");
				var numberAfter = db.Customers.ToList().Count();

				Assert.AreEqual(numberBefore + 1, numberAfter);
			}
		}

		[Test]
		public void WhenANewCustomerIsAdded_TheirDetailsAreCorrect()
		{
			using (var db = new NorthwindContext())
			{
				_crudManager.CreateCustomer("MAND", "Nishant Mandal", "Sparta Global");
				var check = db.Customers.Where(c => c.CustomerId == "MAND");
                foreach (var item in check)
                {
					Assert.AreEqual(item.CustomerId.Trim(), "MAND");
					Assert.AreEqual(item.ContactName, "Nishant Mandal");
					Assert.AreEqual(item.CompanyName, "Sparta Global");
				}
				
			}
		}


		[Test]
		public void WhenACustomersCityIsChanged_TheDatabaseIsUpdated()
		{
			using (var db = new NorthwindContext())
			{
				//_crudManager.CreateCustomer("MAND", "Nishant Mandal", "Sparta Global");
				var newCustomer = new Customer
				{
					CustomerId = "MAND".Trim(),
					ContactName = "Nishant Mandal".Trim(),
					CompanyName = "Sparta Global".Trim()
				};
				db.Customers.Add(newCustomer);
				db.SaveChanges();
				_crudManager.UpdateCustomerCity("MAND", "Paris");
				var selectedCustomer = db.Customers.Where(c => c.CustomerId == "MAND");
                foreach (var item in selectedCustomer)
                {
					Assert.AreEqual(item.City,"Paris");
                }
				
			}
		}


		[Test]
		public void WhenSeveralCustomersDetailsAreChanged_TheDatabaseIsUpdated()
		{
			using (var db = new NorthwindContext())
			{
				//_crudManager.CreateCustomer("MAND", "Nishant Mandal", "Sparta Global");
				var newCustomer = new Customer
				{
					CustomerId = "MAND".Trim(),
					ContactName = "Nishant Mandal".Trim(),
					CompanyName = "Sparta Global".Trim()
				};
				db.Customers.Add(newCustomer);
				db.SaveChanges();
				_crudManager.UpdateCustomerDetails("MAND","Nishant Mandal", "Birmingham", "B74BB","Uk");
				var selectedCustomer = db.Customers.Where(c => c.CustomerId == "MAND");
                foreach (var item in selectedCustomer)
                {
					Assert.AreEqual(item.City, "Birmingham");
					Assert.AreEqual(item.PostalCode, "B74BB");
					Assert.AreEqual(item.Country, "Uk");
				}
			}
		}

		[Test]
		public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
		{
			using (var db = new NorthwindContext())
			{
				//_crudManager.CreateCustomer("MAND", "Nishant Mandal", "Sparta Global");
				var newCustomer = new Customer
				{
					CustomerId = "MAND".Trim(),
					ContactName = "Nishant Mandal".Trim(),
					CompanyName = "Sparta Global".Trim()
				};
				db.Customers.Add(newCustomer);
				db.SaveChanges();
				int before = db.Customers.Count();
				_crudManager.DeleteCustomer("MAND");
				int after = db.Customers.Count();
				Assert.AreEqual(before - 1, after);

			}
		}
	}

}
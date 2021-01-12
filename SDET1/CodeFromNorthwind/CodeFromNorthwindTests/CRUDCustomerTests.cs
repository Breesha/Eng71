using System.Linq;
using CodeFromNorthwindModel;
using CodeFromNorthwindBusiness;
using NUnit.Framework;

namespace NorthwindTests
{
	public class CRUDCustomerTests
	{
		CRUDManager _crudManager = new CRUDManager();

		[SetUp]

		public void Setup()
		{
			using (var db = new NorthwindContext())
			{

				var selectedCustomer =
				from c in db.Customers
				where c.CustomerId == "MAND"
				select c;


				foreach (var c in selectedCustomer)
				{
					db.Customers.RemoveRange(c);
				}

				db.SaveChanges();
			}
		}

		[TearDown]

		public void TearDown()
		{
			using (var db = new NorthwindContext())
			{

				var selectedCustomer =
				from c in db.Customers
				where c.CustomerId == "MAND"
				select c;


				foreach (var c in selectedCustomer)
				{
					db.Customers.RemoveRange(c);
				}

				db.SaveChanges();
			}
		}


		[Test]
		public void WhenANewCustomerIsAdded_TheNumberOfCustemersIncreasesBy1()
		{
			using (var db = new NorthwindContext())
			{

				var numberOfCustomersBefore = db.Customers.ToList().Count();
				_crudManager.CreateCustomer("MAND", "Nish Mandal", "Sparta Global");
				var numberOfCustomersAfter = db.Customers.ToList().Count();

				Assert.AreEqual(numberOfCustomersBefore + 1, numberOfCustomersAfter);


			}
		}

		[Test]
		public void WhenANewCustomerIsAdded_TheirDetailsAreCorrect()
		{
			using (var db = new NorthwindContext())
			{

				var numberOfCustomersBefore = db.Customers.ToList().Count();
				_crudManager.CreateCustomer("MAND", "Nish Mandal", "Sparta Global");
				//var numberOfCustomersAfter = db.Customers.ToList().Count();

				//Assert.AreEqual(numberOfCustomersBefore + 1, numberOfCustomersAfter);

				var createdCustomer =
					from c in db.Customers
					where c.CustomerId == "MAND"
					select c;

				foreach (var c in createdCustomer)
				{
					Assert.AreEqual("Nish Mandal", c.ContactName);
					Assert.AreEqual("Sparta Global", c.CompanyName);

				}

			}
		}


		[Test]
		public void WhenSeveralCustomersDetailsAreChanged_TheDatabaseIsUpdated()
		{
			using (var db = new NorthwindContext())
			{
				var newCustomer = new Customers()
				{
					CustomerId = "MAND",
					ContactName = "Nish Mandal",
					CompanyName = "Sparta Global",
					City = "Birmingham",
					PostalCode = "B77",
					Country = "UK"
				};

				db.Customers.Add(newCustomer);

				db.SaveChanges();

				_crudManager.UpdateCustomer("MAND", "Nish Kumar", "Paris", "B1", "France");

				var SelectedCustomer = db.Customers.Where(c => c.CustomerId == "MAND").FirstOrDefault();


					Assert.AreEqual("Nish Kumar", SelectedCustomer.ContactName);
					Assert.AreEqual("Paris", SelectedCustomer.City);
					Assert.AreEqual("B1", SelectedCustomer.PostalCode);
					Assert.AreEqual("France", SelectedCustomer.Country);
			}
		}

		[Test]
		public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
		{
			using (var db = new NorthwindContext())
			{

				var newCustomer = new Customers()
				{
					CustomerId = "MAND",
					ContactName = "Nish Mandal",
					CompanyName = "Sparta Global"
				};

				db.Customers.Add(newCustomer);

				db.SaveChanges();

				var numberOfCustomersBefore = db.Customers.ToList().Count();

				_crudManager.DeleteCustomer("MAND");

				var numberOfCustomersAfter = db.Customers.ToList().Count();

				Assert.AreEqual(numberOfCustomersBefore - 1, numberOfCustomersAfter);


			}
		}
	}
}
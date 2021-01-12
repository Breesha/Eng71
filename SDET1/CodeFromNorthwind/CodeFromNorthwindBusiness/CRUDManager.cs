using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CodeFromNorthwindModel;
using Microsoft.EntityFrameworkCore;

namespace CodeFromNorthwindBusiness
{
	public class CRUDManager
	{
		//I want a permantant connection to the database
		private ICustomerService _service;
		public Customers SelectedCustomer { get; set; }

		public CRUDManager(ICustomerService service)
        {
            if (service==null)
            {
				throw new NotImplementedException();
            }
			_service = service;
        }

		public CRUDManager()
        {
			_service = new CustomerService(new NorthwindContext());
        }

		public List<Customers> RetrieveAll()
		{
			using (var db = new NorthwindContext())
			{
				return db.Customers.ToList();
			}
		}

		public void SetSelectedCustomer(object selectedItem)
		{
			SelectedCustomer = (Customers)selectedItem;
		}

		static void Main(string[] args)
		{
			using (var db = new NorthwindContext())
			{
				//Delete("MAND");
				//Create("MAND", "Nish Mandal", "ToysRUs");
				//Update("MAND", "Paris");
				//Delete("MAND");


			}
		}

			public void CreateCustomer(string customerid, string contactname, string companyname)
			{
					var newCustomer = new Customers()
					{
						CustomerId = customerid.Trim(),
						ContactName = contactname.Trim(),
						CompanyName = companyname.Trim()
					};

			_service.CreateCustomer(newCustomer);
			}

		public void UpdateCustomer(string customerId, string contactName, string city, string postcode, string country)
		{
				SelectedCustomer = _service.GetCustomerById(customerId);
				SelectedCustomer.ContactName = contactName;
				SelectedCustomer.City = city;
				SelectedCustomer.PostalCode = postcode;
				SelectedCustomer.Country = country;
				// write changes to database
				_service.UpdateCustomer();
		}


			public void DeleteCustomer(string customerid)
			{

				_service.DeleteCustomer(customerid);

			}

		public Customers RetrieveSelectedCustomer(string customerid)
        {
			return _service.GetCustomerById(customerid);
			//return null;
        }

		}
	}






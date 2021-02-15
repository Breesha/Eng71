using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFromNorthwindModel;

namespace CodeFromNorthwindModel
{
    public class CustomerService : ICustomerService
    {
        private readonly NorthwindContext _context;
        public CustomerService(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customers customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(string customerId)
        {
            if (GetCustomerById(customerId)!=null)
            {
                var selectedCustomer = GetCustomerById(customerId);
                _context.Remove(selectedCustomer);
                _context.SaveChanges();
            }
            
        }

        public Customers GetCustomerById(string customerId)
        {
            if (customerId.Length>5)
            {
                throw new Exception("Customer ID is too long");
            }
            return _context.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
        }

        public List<Customers> GetCustomerList()
        {
            return _context.Customers.ToList();
        }

        public void UpdateCustomer()
        {
            _context.SaveChanges();
        }
    }
}
